using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public static class ApiHelper
    {
        private static readonly string baseURL = "https://api.exchangeratesapi.io/";

        public static async Task<string> GetAllRates()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(baseURL + "latest"))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();

                        if(data != null)
                        {
                            return data;
                        }
                    }
                }
            }

            return string.Empty;
        }

        public static async Task<string> GetChangeRate(string depart, string arrivee)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(baseURL + "latest?base=" + depart + ";symbols=" + arrivee))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();

                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }

            return string.Empty;
        }

        public static string BeautifyJason(string jsonString)
        {
            JToken parseJson = JToken.Parse(jsonString);
            return parseJson.ToString(Formatting.Indented);


        }
        }
    }
}
