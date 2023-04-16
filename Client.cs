using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQL_Evaluation_Sommative_3
{
    internal class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Courriel { get; set; }
        public string CarteDeCredit { get; set; }
        public int NumeroDeChambre { get; set; }

        public Client(string nom, string prenom, string courriel, string carteDeCredit, int numeroDeChambre)
        {
            Nom = nom;
            Prenom = prenom;
            Courriel = courriel;
            CarteDeCredit = carteDeCredit;
            NumeroDeChambre = numeroDeChambre;
        }
    }
}
