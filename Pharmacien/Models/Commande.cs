using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacien.Models
{
    public class Client
    {
        public int id { get; set; }
        public string name { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string tel { get; set; }
        public string adresse { get; set; }
    }

    public class Medicament
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string description { get; set; }
        public double prix_unitaire { get; set; }
        public int quantite_stock { get; set; }
        public bool necessite_ordonnance { get; set; }
    }

    public class LigneMedicament
    {
        public int id { get; set; }
        public int quantite { get; set; }
        public double prix_total { get; set; }
        public int id_commande { get; set; }
        public int id_medicament { get; set; }
        public Medicament medicament { get; set; }
    }

    public class Livraison
    {
        public int id { get; set; }
        public string adresse_livraison { get; set; }
        public string statut { get; set; }
        public string justification { get; set; }
        public int id_commande { get; set; }
        public int id_livreur { get; set; }
    }

    public class Commande
    {
        public int id { get; set; }
        public DateTime date_commande { get; set; }
        public string statut { get; set; }
        public string methode_paiement { get; set; }
        public string type_commande { get; set; }
        public int id_client { get; set; }
        public int id_pharmacien { get; set; }
        public Client client { get; set; }
        public Livraison livraison { get; set; }
        public List<LigneMedicament> ligne_medicaments { get; set; }
    }
}
