using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQL_Evaluation_Sommative_3
{
    internal class Hotel
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public int NombreDeChambres { get; set; }
        public ArrayList Clients { get; set; }

        public Hotel(string nom, string adresse, int nombreDeChambres)
        {
            Nom = nom;
            Adresse = adresse;
            NombreDeChambres = nombreDeChambres;
            Clients = new ArrayList();
        }

        public void AjouterClient(Client client)
        {
            Clients.Add(client);
        }
    }
}
