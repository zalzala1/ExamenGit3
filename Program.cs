namespace Finalygit3
{
    internal class Program
    {
        static void Main(string[] args)
        { Hotel hotel = new Hotel();

            Client client1 = new Client("Doe", "John", "john.doe@example.com", "1234-5678-9101-1121", 101);
            hotel.AjouterClient(client1);

            Client client2 = new Client("Smith", "Jane", "jane.smith@example.com", "4321-8765-1098-7654", 102);
            hotel.AjouterClient(client2);

            Console.WriteLine("Clients dans l'hôtel :");
            foreach (Client client in hotel.Clients)
            {
                Console.WriteLine($"Nom: {client.Nom}, Prénom: {client.Prenom}, Courriel: {client.Courriel}, Carte de crédit: {client.CarteCredit}, Numéro de chambre: {client.NumeroChambre}");
            }
            Console.WriteLine("Hello, World!");
        } 
        public Client(string nom, string prenom, string courriel, string carteCredit, int numeroChambre)
        {
            Nom = nom;
            Prenom = prenom;
            Courriel = courriel;
            CarteCredit = carteCredit;
            NumeroChambre = numeroChambre;
        }
          public Hotel()
        {
            Clients = new ArrayList();
        }

        public void AjouterClient(Client client)
        {
            Clients.Add(client);
        }
    }
}
