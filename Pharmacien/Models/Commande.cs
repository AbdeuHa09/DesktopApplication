using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Pharmacien.Models
{
    public class Client
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("prenom")]
        public string prenom { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("tel")]
        public string tel { get; set; }

        [JsonProperty("adresse")]
        public string adresse { get; set; }
    }

    public class Medicament
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("nom")]
        public string nom { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("prix_unitaire")]
        public double prix_unitaire { get; set; }

        [JsonProperty("quantite_stock")]
        public int quantite_stock { get; set; }

        [JsonProperty("necessite_ordonnance")]
        public bool necessite_ordonnance { get; set; }
    }

    public class LigneMedicament
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("quantite")]
        public int quantite { get; set; }

        [JsonProperty("prix_total")]
        public double prix_total { get; set; }

        [JsonProperty("id_commande")]
        public int id_commande { get; set; }

        [JsonProperty("id_medicament")]
        public int id_medicament { get; set; }

        [JsonProperty("medicament")]
        public Medicament medicament { get; set; }
    }

    public class Livraison
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("adresse_livraison")]
        public string adresse_livraison { get; set; }

        [JsonProperty("statut")]
        public string statut { get; set; }

        [JsonProperty("justification")]
        public string justification { get; set; }

        [JsonProperty("id_commande")]
        public int id_commande { get; set; }

        [JsonProperty("id_livreur")]
        public int id_livreur { get; set; }
    }

    public class Commande
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("date_commande")]
        public DateTime date_commande { get; set; }

        [JsonProperty("statut")]
        public string statut { get; set; }

        [JsonProperty("methode_paiement")]
        public string methode_paiement { get; set; }

        [JsonProperty("type_commande")]
        public string type_commande { get; set; }

        [JsonProperty("id_client")]
        public int id_client { get; set; }

        [JsonProperty("id_pharmacien")]
        public int id_pharmacien { get; set; }

        [JsonProperty("client")]
        public Client client { get; set; }

        [JsonProperty("livraison")]
        public Livraison livraison { get; set; }

        [JsonProperty("ligne_medicaments")]
        public List<LigneMedicament> ligne_medicaments { get; set; }

        [JsonProperty("ordonnance")]
        public Ordonnance ordonnance { get; set; }

        [JsonProperty("symptome")]
        public Symptome symptome { get; set; }
    }
}