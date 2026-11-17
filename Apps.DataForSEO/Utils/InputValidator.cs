using System.Globalization;
using Blackbird.Applications.Sdk.Common.Exceptions;
using Newtonsoft.Json.Linq;

namespace Apps.DataForSEO.Utils;

public static class InputValidator
{
    public static void Required(object? value, string name)
    {
        if (value == null || value is string text && string.IsNullOrWhiteSpace(text) || value is System.Collections.ICollection collection && collection.Count == 0)
            throw new PluginMisconfigurationException($"Fill in '{name}' or map a value from a previous step.");
    }

    public static long Code(string value, string name)
    {
        if (!long.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var code))
            throw new PluginMisconfigurationException($"Enter a numeric {name} from the suggestions or map a valid provider code.");
        return code;
    }

    public static JToken Json(string value, string name, string type)
    {
        try
        {
            var token = JToken.Parse(value);
            if (type == "array" && token.Type != JTokenType.Array || type == "object" && token.Type != JTokenType.Object)
                throw new PluginMisconfigurationException($"'{name}' must contain a JSON {type}.");
            return token;
        }
        catch (Newtonsoft.Json.JsonException)
        {
            throw new PluginMisconfigurationException($"'{name}' is not valid JSON. Use the documented example.");
        }
    }

    public static void Validate(Dictionary<string, object> body)
    {
        if (body.TryGetValue("date_from", out var from) && body.TryGetValue("date_to", out var to) && string.CompareOrdinal(from.ToString(), to.ToString()) > 0)
            throw new PluginMisconfigurationException("Start date must be on or before end date.");
        if (body.TryGetValue("max_crawl_pages", out var pages) && Convert.ToInt64(pages) < 1)
            throw new PluginMisconfigurationException("Maximum crawl pages must be greater than zero.");
        if (body.TryGetValue("platform", out var platform) && platform.ToString() == "chat_gpt" && (body.GetValueOrDefault("location_code")?.ToString() != "2840" || body.GetValueOrDefault("language_code")?.ToString() != "en"))
            throw new PluginMisconfigurationException("ChatGPT mentions require United States (2840) and English (en).");
        if (body.TryGetValue("device", out var device) && body.TryGetValue("os", out var os))
        {
            var incompatible = device.ToString() == "desktop" && (os.ToString() is "android" or "ios") || device.ToString() == "mobile" && (os.ToString() is "windows" or "macos");
            if (incompatible)
                throw new PluginMisconfigurationException("Select an operating system compatible with the device, or leave OS empty.");
        }
    }
}
