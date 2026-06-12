using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Pharmacien.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacien.Services
{
    // Classe wrapper générique pour toutes les réponses API
    public class ApiResponse<T>
    {
        public string message { get; set; }
        public T data { get; set; }
    }

    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerSettings _jsonSettings;
        private const string BASE_URL = "http://localhost:8000/api";

        public ApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            // Configuration pour snake_case (format Laravel)
            _jsonSettings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                },
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
        }

        public void SetToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Remove("Authorization");
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
        }

        public async Task<LoginResponse> Login(string email, string password)
        {
            var data = new { email, password };
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{BASE_URL}/pharmacien/login", content);
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<LoginResponse>(json, _jsonSettings);
        }

        public async Task<List<Commande>> GetCommandes()
        {
            var response = await _httpClient.GetAsync($"{BASE_URL}/pharmacien/commandes");
            var json = await response.Content.ReadAsStringAsync();
            
            return JsonConvert.DeserializeObject<List<Commande>>(json, _jsonSettings) ?? new List<Commande>();
        }

        public async Task<Commande> GetCommande(int id)
        {
            var response = await _httpClient.GetAsync($"{BASE_URL}/pharmacien/commande/{id}");
            var json = await response.Content.ReadAsStringAsync();

            // Désérialiser l'objet wrapper
            var wrapper = JsonConvert.DeserializeObject<ApiResponse<Commande>>(json, _jsonSettings);

            // Retourner le data
            return wrapper?.data;
        }

        public async Task<string> ValiderCommande(int commandeId, int livreurId)
        {
            var data = new { id_livreur = livreurId };
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"{BASE_URL}/pharmacien/commande/{commandeId}/valider", content);
            var json = await response.Content.ReadAsStringAsync();
            return json;
        }

        public async Task<string> RefuserCommande(int commandeId, string justification)
        {
            var data = new { justification };
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"{BASE_URL}/pharmacien/commande/{commandeId}/refuser", content);
            var json = await response.Content.ReadAsStringAsync();
            return json;
        }

        public async Task<List<Livreur>> GetLivreurs()
        {
            var response = await _httpClient.GetAsync($"{BASE_URL}/pharmacien/livreurs");
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Livreur>>(json, _jsonSettings) ?? new List<Livreur>();
        }

        public async Task<List<Medicament>> GetMedicaments()
        {

            var response = await _httpClient.GetAsync($"{BASE_URL}/pharmacien/medicaments");
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Medicament>>(json, _jsonSettings) ?? new List<Medicament>();
        }

        public async Task<string> UpdateStock(int medicamentId, int quantiteStock)
        {
            var data = new { quantite_stock = quantiteStock };
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"{BASE_URL}/pharmacien/medicaments/{medicamentId}/stock", content);
            var json = await response.Content.ReadAsStringAsync();
            return json;
        }
        public async Task<bool> AjouterMedicament(Medicament medicament)
        {
            var content = new StringContent(JsonConvert.SerializeObject(medicament), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{BASE_URL}/pharmacien/medicaments", content);
            return response.IsSuccessStatusCode;
        }
        public async Task<byte[]> DownloadOrdonnance(int ordonnanceId)
        {
            var response = await _httpClient.GetAsync($"{BASE_URL}/pharmacien/ordonnance/{ordonnanceId}/download");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsByteArrayAsync();
            }

            return null;
        }
        public async Task<string> ProposerMedicaments(int commandeId, List<object> medicaments)
        {
            var data = new { medicaments };
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{BASE_URL}/pharmacien/commande/{commandeId}/proposer", content);
            var json = await response.Content.ReadAsStringAsync();
            return json;
        }
        public async Task<bool> UpdateStatutPharmacie(string statut)
        {
            var data = new { statut_pharmacie = statut };
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"{BASE_URL}/pharmacien/statut", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<string> GetStatutPharmacie()
        {
            var response = await _httpClient.GetAsync($"{BASE_URL}/pharmacien/statut");
            var json = await response.Content.ReadAsStringAsync();
            dynamic result = JsonConvert.DeserializeObject(json);
            return result?.statut_pharmacie?.ToString();
        }
        public async Task<string> ProposerMedicaments(int commandeId, List<object> medicaments, string type = "symptomes")
        {
            string endpoint = type == "ordonnance"
                ? $"{BASE_URL}/pharmacien/commande/{commandeId}/proposer-ordonnance"
                : $"{BASE_URL}/pharmacien/commande/{commandeId}/proposer";

            var data = new { medicaments };
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(endpoint, content);
            var json = await response.Content.ReadAsStringAsync();
            return json;
        }
        public async Task<string> ProposerMedicamentsOrdonnance(int commandeId, List<object> medicaments)
        {
            var data = new { medicaments };
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"{BASE_URL}/pharmacien/commande/{commandeId}/proposer-ordonnance", content);
            var json = await response.Content.ReadAsStringAsync();
            return json;
        }

    }
}