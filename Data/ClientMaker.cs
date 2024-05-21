using Newtonsoft.Json;
using System.IO;

namespace Wpf_Bank_A.Data
{
    public class ClientMaker
    {
        private string filePath;

        public ClientMaker(string filePath)
        {
            this.filePath = filePath;

            string directoryPath = Path.GetDirectoryName(filePath);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]");
            }
        }

        public void SaveClient(Client client)
        {
            var clients = LoadClients();

            var existingClient = clients.FirstOrDefault(c => c.Id == client.Id);

            if (existingClient != null)
            {
                existingClient.FullName = client.FullName;
                existingClient.PhoneNumber = client.PhoneNumber;
                existingClient.PassportSeries = client.PassportSeries;
                existingClient.PassportNumber = client.PassportNumber;
                existingClient.LastModificationDateTime = DateTime.Now;
                existingClient.ModificationType = client.ModificationType;
            }
            else
            {
                clients.Add(client);
            }

            SaveClients(clients);
        }

        public List<Client> LoadClients()
        {
            string json = File.ReadAllText(filePath);
            List<Client> clients = JsonConvert.DeserializeObject<List<Client>>(json);
            return clients ?? new List<Client>();
        }

        private void SaveClients(List<Client> clients)
        {
            string json = JsonConvert.SerializeObject(clients, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
