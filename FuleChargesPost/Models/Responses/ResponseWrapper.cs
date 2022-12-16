using Newtonsoft.Json;

namespace FuleChargesPost.Models.Responses;

public class ResponseWrapper
{
    [JsonProperty("response")] public Response Response { get; set; } = new();
    [JsonProperty("apiVersion")] public string ApiVersion { get; set; } = string.Empty;
}