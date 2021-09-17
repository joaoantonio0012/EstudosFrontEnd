using AppLogin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace AppLogin.Servicos
{
    class ApiServices
    {
        string rotaBase = "https://api.appimob.com.br/api" + "/autenticacao/usuario";
        string rotaRecuperarUsuario = "https://api.appimob.com.br/api" + "/recuperarporusuariologado";
        private static ApiServices _ApiServicesInstance;
       // private JsonSerializer jsonserializer = new JsonSerializer();
        private HttpClient client;

        public static ApiServices ApiServicesInstance
        {
            get
            {
                if (_ApiServicesInstance == null)
                    _ApiServicesInstance = new ApiServices();
                return _ApiServicesInstance;
            }
        }
        public ApiServices()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<bool> AuthenticateUserAsync(string Username, string PassWord)
        {
            ApiResponseLoginModel responseLoginModel = new ApiResponseLoginModel();
            try
            {
                ApiRequestLoginModel apiRequestLoginModel = new ApiRequestLoginModel()
                {
                    username = "admin",
                    password = "admin1",
                    grant_type = "password"
                };

                var data = new List<KeyValuePair<string, string>>();

                data.Add(new KeyValuePair<string, string>("username", apiRequestLoginModel.username));
                data.Add(new KeyValuePair<string, string>("password", apiRequestLoginModel.password));
                data.Add(new KeyValuePair<string, string>("grant_type", apiRequestLoginModel.grant_type));

                var content = new FormUrlEncodedContent(data);

                var response = await client.PostAsync(rotaBase, content);
                if (response.IsSuccessStatusCode)
                {

                    var resultadoAutenticacao = new teste();
                    resultadoAutenticacao = JsonConvert.DeserializeObject<teste>(response.Content.ReadAsStringAsync().Result);

                    Preferences.Set("authToken", resultadoAutenticacao.access_token);
                    return true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            return false;

        }
        public async Task<PessoaModel> RecuperarUserAsync()
        {
            try
            {
                var token = Preferences.Get("authToken", "");

                if (token != null && token != "")
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    var response = await client.GetAsync(rotaRecuperarUsuario);
                    if (response.IsSuccessStatusCode)
                    {

                        var pessoaLogada = new PessoaModel();
                        var options = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        };
                        //var pessoaLogadaw = JsonConvert.DeserializeObject<UsuarioModel>(response.Content.ReadAsStringAsync().Result, options');
                        var resultado = System.Text.Json.JsonSerializer.Deserialize<RetornoModel<PessoaModel>>(response.Content.ReadAsStringAsync().Result, options);
                        pessoaLogada = resultado.Data;

                        Preferences.Set("LogadoNome", pessoaLogada.Apelido.ToString() != "" ? pessoaLogada.Apelido.ToString():pessoaLogada.Nome.ToString());
                        return pessoaLogada;
                    }
                }
                return null;


            }
            catch (Exception)
            {

                throw;
            }
            return null;

        }
    }
}
