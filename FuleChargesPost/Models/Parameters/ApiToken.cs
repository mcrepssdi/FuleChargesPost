using Newtonsoft.Json;

namespace FuleChargesPost.Models.Parameters;

public class ApiToken
{
    [JsonProperty("api_key")] public string api_key { get; set; } = "dZE55OySRUtvlZ5ccTAaGO2YXNTn5GoUiaCha8kE";
}