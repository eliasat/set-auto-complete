namespace SetAutoComplete
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json;

    public static class SetAutoComplete
    {
        [FunctionName("SetAutoComplete")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]
            HttpRequest req, ILogger log)
        {
            log.LogInformation("SetAutoComplete function processed a request.");

            var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var prCreatedReq = JsonConvert.DeserializeObject<PRCreatedHookBody>(requestBody);

            var reqBody = new SetAutoCompleteReq();
            reqBody.AutoCompleteSetBy.Id = Environment.GetEnvironmentVariable("AccountId");
            var responseBody = "";
            try
            {
                var pat = Environment.GetEnvironmentVariable("PAT");
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(
                            Encoding.ASCII.GetBytes(
                                string.Format("{0}:{1}", "", pat))));

                    var url = $"{prCreatedReq.Resource.Url}?api-version=5.0";
                    var jsonContent = JsonConvert.SerializeObject(reqBody);
                    var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                    using (var response = await client.PatchAsync(url, httpContent))
                    {
                        responseBody = await response.Content.ReadAsStringAsync();
                        response.EnsureSuccessStatusCode();
                    }
                }
            }
            catch (Exception ex)
            {
                log.LogError(responseBody);
                log.LogError(ex.ToString());
                throw ex;
            }

            return new OkObjectResult(responseBody);
        }
    }
}
