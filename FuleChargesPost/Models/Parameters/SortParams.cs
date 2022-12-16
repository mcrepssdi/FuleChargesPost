using Newtonsoft.Json;

namespace FuleChargesPost.Models.Parameters;

public class SortParams
{
    [JsonProperty("column")] public string Column { get; set; } = string.Empty;
    [JsonProperty("direction")] public string Direction { get; set; } = string.Empty;
}