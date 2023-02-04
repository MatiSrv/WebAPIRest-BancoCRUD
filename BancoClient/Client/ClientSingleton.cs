using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BancoClient.Client
{
    public class ClientSingleton
    {
        private static ClientSingleton instancia;
        private HttpClient client;

        private ClientSingleton()
        {
            client= new HttpClient();
        }
        public static ClientSingleton GetClient()
        {
            if(instancia == null)
            {
                instancia = new ClientSingleton();
                return instancia;
            }
            return instancia;
        }

        public async Task<string> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }
        //public async Task<string> GetAsyncTC(string url)
        //{
        //    var result = await client.GetAsync(url);
        //    var content = "";
        //    if (result.IsSuccessStatusCode)
        //        content = await result.Content.ReadAsStringAsync();
        //    return content;
        //}

        public async Task<string> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(url, content);
            var response = "";

            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();

            return response;
        }
        public async Task<string> PutAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await client.PutAsync(url, content);
            var response = "";

            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();

            return response;
        }
        public async Task<string> DeleteAsync(string url, int dni)
        {
            string URL = $"{url}?dni={dni}";
            var result = await client.DeleteAsync(URL);
            var response = "";

            if (result.IsSuccessStatusCode)
                response= await result.Content.ReadAsStringAsync();
            return response;
        }
        public async Task<string> DeleteAsyncCta(string url, int cta)
        {
            string URL = url+cta;
            var result = await client.DeleteAsync(URL);
            var response = "";

            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }

    }
}
