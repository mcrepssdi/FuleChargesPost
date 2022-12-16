// See https://aka.ms/new-console-template for more information

using System.Net;
using FuleChargesPost.Models.Parameters;
using FuleChargesPost.Models.Responses;
using Newtonsoft.Json;
using NLog;
using SdiHttpLib;


Logger logger = LogManager.GetCurrentClassLogger();
logger.Trace("Fuel Charges Post Starting....");

const string url = "https://api.eia.gov/v2/petroleum/pri/gnd/data/";
Params postParams = new ()
{
    Frequency = "weekly",
    Data = new[] {"value"},
    Facets = new FacetParams
    {
        Duoreas = new[] {"R20"},
        Products = new[] {"EPD2D"}
    },
    Sort = new List<SortParams>
    {
        new() {Column = "period", Direction = "desc"}
    },
    StartDate = null,
    EndtDate = null
};
string jsonHdrs = JsonConvert.SerializeObject(postParams);

IHttp http = new SdiHttp(logger);
Task<(HttpStatusCode httpStatusCode, string responseText)> testresp = http.Get(new ApiToken(), url,
    new List<(string key, string value)>
        {new ValueTuple<string, string>("X-Params", jsonHdrs)});
testresp.Wait();

if (testresp.Result.httpStatusCode == HttpStatusCode.OK)
{
    ResponseWrapper? resp = JsonConvert.DeserializeObject<ResponseWrapper>(testresp.Result.responseText);
}

logger.Trace("Fuel Charges Post... Completed");
