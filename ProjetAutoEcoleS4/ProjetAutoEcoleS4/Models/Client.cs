using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAutoEcoleS4.Models
{
    internal class Client
    {
        private string codeNEPH;//Clé primaire identifiable
        private string nom;
        private string prenom; //Auto ou manuelle
        private string tel;
        private string mail;
        private string type_eleve;
        private string adresse;
        private string rib;
        private DateTime dateNaissance;
        private string permis;
        private string boite; //pas un bool?
        private string moniteurTitre;
        private int nbHeureARegler;
        private int montantReglementRestant; //Je propose de ne PAS mettre ça.
    }
}
