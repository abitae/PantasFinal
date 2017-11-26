using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantasFinal.Models
{
    public class Enfermedades
    {

        [JsonProperty("IdEnfermedad")]
        public int IdEnfermedad { get; set; }

        [JsonProperty("Nombre")]
        public string Nombre { get; set; }

        [JsonProperty("Definicion")]
        public string Definicion { get; set; }

        [JsonProperty("Caracteristicas")]
        public string Caracteristicas { get; set; }

        [JsonProperty("Causas")]
        public string Causas { get; set; }

        [JsonProperty("UrlYou")]
        public string UrlYou { get; set; }
    } }