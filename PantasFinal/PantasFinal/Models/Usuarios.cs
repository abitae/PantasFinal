using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantasFinal.Models
{
    public class Usuarios
    {

        [JsonProperty("IdUsuario")]
        public int IdUsuario { get; set; }

        [JsonProperty("Usuario")]
        public string Usuario { get; set; }

        [JsonProperty("Pasword")]
        public string Pasword { get; set; }

        [JsonProperty("IsRemembered")]
        public bool IsRemembered { get; set; }
    }

}
