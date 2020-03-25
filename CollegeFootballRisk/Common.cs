using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CollegeFootballRisk
{
    internal static class Common
    {
        private static readonly HttpClient client = new HttpClient();

        internal async static Task<T> GetAsync<T>(string baseUrl, string query)
        {
            var str = await client.GetStringAsync($"{baseUrl}{query}");
            return JsonConvert.DeserializeObject<T>(str);
        }
    }
}
