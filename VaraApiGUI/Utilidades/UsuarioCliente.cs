using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VaraApiGUI.Modelos;
using static VaraApiGUI.Modelos.VaramientoJSON;

namespace VaraApiGUI.Utilidades
{
    public static class UsuarioCliente
    {
        public static UsuarioJSON usuarioJSON { get; set; }
        public static Varamiento varamiento { get; set; }
        public static string token { get; set; }
        public static Usuario usuario { get; set; }
        public static async Task IniciarSesion()
        {
            HttpClient client = new HttpClient();
            // client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var stringContent = new StringContent(JsonConvert.SerializeObject(usuario), Encoding.UTF8, "application/json");

            HttpResponseMessage respuesta = await client.PostAsync("http://ec2-3-137-222-34.us-east-2.compute.amazonaws.com/auth/token", stringContent);
            string mensaje = await respuesta.Content.ReadAsStringAsync();
            usuarioJSON = JsonConvert.DeserializeObject<UsuarioJSON>(mensaje);
            token = usuarioJSON.token;
        }

        public static bool RegistrarVaramiento()
        {
            var client = new RestClient("http://ec2-3-137-222-34.us-east-2.compute.amazonaws.com//yo/varamientos");
            client.AddDefaultHeader("Authorization", $"bearer {token}");
            var request = new RestRequest("Default", Method.POST);
            //request.AddHeader("Accept", "application/json");
            //request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(request.JsonSerializer.Serialize(varamiento));

            var response = client.Execute(request);
            Console.WriteLine(response.Content);
            if (response.IsSuccessful)
            {
                return true;
            } else
            {
                return false;
            }
        }

        //public static VaramientoResultados BuscarVaramiento()
        //{
        //    var client = new RestClient("");
        //    // client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        //    var stringContent = new StringContent(JsonConvert.SerializeObject(usuario), Encoding.UTF8, "application/json");

        //    HttpResponseMessage respuesta = await client.PostAsync("http://ec2-3-137-222-34.us-east-2.compute.amazonaws.com/auth/token", stringContent);
        //    string mensaje = await respuesta.Content.ReadAsStringAsync();
        //    usuarioJSON = JsonConvert.DeserializeObject<UsuarioJSON>(mensaje);
        //    token = usuarioJSON.token;
        //}

    }
}
