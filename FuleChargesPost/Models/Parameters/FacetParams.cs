using Newtonsoft.Json;

namespace FuleChargesPost.Models.Parameters;

public class FacetParams
{
    [JsonProperty("duoarea")] public string[] Duoreas { get; set; } = Array.Empty<string>();
    [JsonProperty("product")] public string[] Products { get; set; } = Array.Empty<string>();
}