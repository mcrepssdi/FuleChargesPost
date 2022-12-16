
using Newtonsoft.Json;

namespace FuleChargesPost.Models.Responses;

public class FuelCost
{
    [JsonProperty("period")] public string Period { get; set; } = string.Empty;
    [JsonProperty("duoarea")] public string Duoarea { get; set; } = string.Empty;
    [JsonProperty("area-name")] public string AreaName { get; set; } = string.Empty;
    [JsonProperty("product")] public string Product { get; set; } = string.Empty;
    [JsonProperty("product-name")]public string ProductName { get; set; } = string.Empty;
    [JsonProperty("process")]  public string Process { get; set; } = string.Empty;
    [JsonProperty("process-name")] public string ProcessName { get; set; } = string.Empty;
    [JsonProperty("series")] public string Series { get; set; } = string.Empty;
    [JsonProperty("series-description")] public string SeriesDescription { get; set; } = string.Empty;
    [JsonProperty("value")] public double Value { get; set; }
    [JsonProperty("units")] public string Units { get; set; } = string.Empty;
}