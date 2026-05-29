using Newtonsoft.Json;

namespace Pharmacien.Models
{
    public class Livreur
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("prenom")]
        public string prenom { get; set; }

        [JsonProperty("tel")]
        public string tel { get; set; }
    }
}