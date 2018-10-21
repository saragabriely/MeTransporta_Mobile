using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Teste03.Models;
using Teste03.Views;
using Teste03.Services;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace Teste03.Services
{
    public class DataService
    {
        /*
        public GenericDataService<Cliente>{

            HttpClient client; // = new HttpClient();
            //string url = "https: //webapimt2.azurewebsites.net/api/cliente/";
            string url = "https://webapimt2.azurewebsites.net/api/" + typeof(Cliente).Name.ToString() + "/";

            public async Task<List<Cliente>> Get()
            {
                try
                {
                   // string url = " https:/ /webapimt2.azurewebsites .net/api/cliente/ ";
                    var httpClient = new HttpClient();
                    var response   = await client.GetStringAsync(url);
                    var clientes   = JsonConvert.DeserializeObject<List<Cliente>>(response);
                    return clientes;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        /*
        public async Task AddClienteAsync(Cliente cliente)
        {
            try
            {
                string url = "https:/ /webapimt2.azurewebsites.net/api/cliente/";

                var uri = new Uri(string.Format(url, cliente.idCliente));

                var data = JsonConvert.SerializeObject(cliente);
                var content = new StringContent(data, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;

                response = await client.PostAsync(uri, content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao cadastrar cliente!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } * /

            public async Task<bool> PutAsync(int id, Cliente cliente)
            {
                var httpClient = new HttpClient();

                var json = JsonConvert.SerializeObject(t);

                HttpContent httpContent = new StringContent(json);

                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var result = await httpClient.PutAsync(url + id, httpContent);

                return result.IsSuccessStatusCode;
            }

        /*
        public async Task UpdateClienteAsync(Cliente cliente)
            {
                //string url = "https:/ /webapimt2.azurewebsites.net/api/cliente/{0}";

                var uri = new Uri(string.Format(url, cliente.idCliente));

                var data = JsonConvert.SerializeObject(cliente);
                var content = new StringContent(data, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                response = await client.PutAsync(uri, content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao atualizar cadastro de cliente!");
                }
            }
         * /
            public async Task DeletaClienteAsync(Cliente cliente)
            {
                string url = "https:/ /webapimt2.azurewebsites.net/api/cliente/{0}";

                var uri = new Uri(string.Format(url, cliente.idCliente));

                await client.DeleteAsync(uri);
            }
        }
        */
    }
}
