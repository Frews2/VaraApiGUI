using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaraApiGUI.Modelos
{
    public class UsuarioJSON
    {
        [JsonProperty("usuario")]
        public string Usuario { get; set; }
        [JsonProperty("token")]
        public string token { get; set; }
        [JsonProperty("refreshToken")]
        public string refreshToken { get; set; }
    }
}
