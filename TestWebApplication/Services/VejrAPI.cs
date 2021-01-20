using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TestWebApplication.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Headers;

namespace TestWebApplication.Services
{
    public class VejrAPI
    {
        private HttpClient client;

        public VejrAPI()
        {
            //Self signed Certificate
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            client = new HttpClient(clientHandler);
            //Ignore bad certificate in .NET core 2.0
            // System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        public async Task<VejrModel> GetVejr()
        {
            VejrModel vejrObjekt = new VejrModel();
            try
            {
                string apiUrl = "https://radeoh.app/api/stations/";
                Uri uri = new Uri(string.Format(apiUrl, string.Empty));
                HttpResponseMessage response = await client.GetAsync(uri).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);
                    vejrObjekt = JsonSerializer.Deserialize<VejrModel>(responseBody);
                }


                return vejrObjekt;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return vejrObjekt;
            }
        }
    }
}
