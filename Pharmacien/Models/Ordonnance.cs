using System;
using Newtonsoft.Json;

namespace Pharmacien.Models
{
    public class Ordonnance
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("fichier")]
        public string fichier { get; set; }

        [JsonProperty("date_telechargement")]
        public DateTime date_telechargement { get; set; }

        [JsonProperty("statut")]
        public string statut { get; set; }
    }
}