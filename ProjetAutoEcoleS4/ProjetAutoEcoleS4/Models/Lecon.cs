using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAutoEcoleS4.Models
{
    internal class Lecon
    {
        private int id_Lecon;//Clé primaire
        private DateTime date;
        private string eleve; //Auto ou manuelle
        private string moniteur;
        private string vehicule;
        private int montantFacture;
    }
}
