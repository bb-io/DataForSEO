using Blackbird.Applications.Sdk.Common;
using Newtonsoft.Json;

namespace Apps.DataForSEO.Models.Dtos;

public class TableContentItemInfo
{
    [Display("Row cells")]
    [JsonProperty("row_cells", NullValueHandling = NullValueHandling.Ignore)]
    public List<RowCellInfo> RowCells { get; set; } = [];
}
