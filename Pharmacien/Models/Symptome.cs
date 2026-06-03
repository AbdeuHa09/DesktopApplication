using Newtonsoft.Json;

namespace Pharmacien.Models
{
    public class Symptome
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("allergies")]
        public string allergies { get; set; }

        [JsonProperty("id_client")]
        public int id_client { get; set; }
    }
}