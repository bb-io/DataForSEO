using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Apps.DataForSEO.Utils;

public class JsonTextConverter : JsonConverter
{
    public override bool CanConvert(Type objectType) => objectType == typeof(string);

    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        var token = JToken.Load(reader);
        return token.Type == JTokenType.Null ? null : token.Type == JTokenType.String ? token.Value<string>() : token.ToString(Formatting.None);
    }

    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) => writer.WriteValue(value);
}
