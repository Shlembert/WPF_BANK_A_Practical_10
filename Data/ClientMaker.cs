using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Wpf_Bank_A.Data
{
    public class ClientMaker
    {
        private string filePath;

        public ClientMaker(string filePath)
        {
            this.filePath = filePath;
        }

        public List<Client> LoadClients()
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Client>>(jsonData);
            }
            return new List<Client>();
        }

        public void SaveClient(Client client)
        {
            var clients = LoadClients();
            clients.Add(client);
            SaveClientsToFile(clients);
        }

        public void UpdateClient(Client updatedClient)
        {
            var clients = LoadClients();
            var existingClient = clients.FirstOrDefault(c => c.Id == updatedClient.Id);
            if (existingClient != null)
            {
                existingClient.FullName = updatedClient.FullName;
                existingClient.PhoneNumber = updatedClient.PhoneNumber;
                existingClient.PassportSeries = updatedClient.PassportSeries;
                existingClient.PassportNumber = updatedClient.PassportNumber;
                existingClient.LastModificationDateTime = updatedClient.LastModificationDateTime;
                existingClient.ModificationType = updatedClient.ModificationType;
                SaveClientsToFile(clients);
            }
        }

        public void SaveClientPhoneNumberChange(Client updatedClient)
        {
            var clients = LoadClients();
            var existingClient = clients.FirstOrDefault(c => c.Id == updatedClient.Id);
            if (existingClient != null)
            {
                existingClient.PhoneNumber = updatedClient.PhoneNumber;
                existingClient.ModificationType = updatedClient.ModificationType;
                SaveClientsToFile(clients);
            }
        }

        private void SaveClientsToFile(List<Client> clients)
        {
            string jsonData = JsonConvert.SerializeObject(clients, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }
    }
}
