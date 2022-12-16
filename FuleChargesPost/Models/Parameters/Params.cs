using Newtonsoft.Json;

namespace FuleChargesPost.Models.Parameters;

public class Params
{
    [JsonProperty("frequency")] public string Frequency { get; set; } = "weekly";
    [JsonProperty("data")] public string[] Data { get; set; } = Array.Empty<string>();
    [JsonProperty("facets")] public FacetParams Facets { get; set; } = new();
    [JsonProperty("start")] public string? StartDate { get; set; } = null;
    [JsonProperty("end")] public string? EndtDate { get; set; } = null;
    [JsonProperty("sort")] public List<SortParams> Sort { get; set; } = new();
}