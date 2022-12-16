using Newtonsoft.Json;

namespace FuleChargesPost.Models.Responses;

public class Response
{
    [JsonProperty("total")] public int Total { get; set; }
    [JsonProperty("dateFormat")] public string DateFormat { get; set; } = string.Empty;
    [JsonProperty("frequency")] public string Frequency { get; set; }= string.Empty;
    [JsonProperty("data")] public List<FuelCost> FuelCosts { get; set; } = new();
}