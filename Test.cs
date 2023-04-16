using AQL_Evaluation_Sommative_3;

internal class Test
{
    private static void Main(string[] args)
    {
        // Initialisation d'une instance de la classe Hotel
        Hotel hotel = new Hotel("Hotel Zaki", "1470 Rue de Chinook", 15000);

        // Ajout de quelques clients à la liste de clients
        Client client1 = new Client("Zerouali", "Hamza", "zrewlate-hamza@gmail.com", "1234-5678-9012-3456", 1001);
        hotel.AjouterClient(client1);

        Client client2 = new Client("Bayou", "Otmane", "otmane.bayou@hotmail.com", "2345-6789-0123-4567", 2020);
        hotel.AjouterClient(client2);

        Client client3 = new Client("Assaka", "Nissrine", "Assaka_Niss@ourlook.fr", "3456-7890-1234-5678", 13000);
        hotel.AjouterClient(client3);

        // Affichage de la liste des clients de l'hôtel
        Console.WriteLine("La liste des clients de l'hôtel :");
        foreach (Client client in hotel.Clients)
        {
            Console.WriteLine(client.Nom + " " + client.Prenom + " - Chambre " + client.NumeroDeChambre);
        }

        // Pause pour voir les résultats
        Console.ReadLine();
    }
}