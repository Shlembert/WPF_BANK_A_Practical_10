using Newtonsoft.Json;
using System.IO;

namespace Wpf_Bank_A.Data
{
    public class ClientMaker
    {
        private string filePath; // Путь к файлу для сохранения данных

        public ClientMaker(string filePath)
        {
            this.filePath = filePath;

            // Получаем путь к папке
            string directoryPath = Path.GetDirectoryName(filePath);

            // Проверяем наличие папки
            if (!Directory.Exists(directoryPath))
            {
                // Создаем папку, если она не существует
                Directory.CreateDirectory(directoryPath);
            }

            // Создаем файл, если он не существует
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]");
            }
        }

        public void SaveClient(Client client)
        {
            // Загружаем существующие клиенты
            var clients = LoadClients();

            // Ищем клиента по его идентификатору (например, по имени или номеру паспорта)
            var existingClient = clients.FirstOrDefault(c => c.FullName == client.FullName);

            if (existingClient != null)
            {
                // Обновляем существующего клиента
                existingClient.PhoneNumber = client.PhoneNumber;
                existingClient.LastModificationDateTime = DateTime.Now;
                existingClient.ModificationType = client.ModificationType;
                existingClient.ModifiedBy = client.ModifiedBy;
            }
            else
            {
                // Если клиент не найден, добавляем нового клиента
                clients.Add(client);
            }

            // Сохраняем обновленный список клиентов
            SaveClients(clients);
        }


        public List<Client> LoadClients()
        {
            // Читаем JSON из файла
            string json = File.ReadAllText(filePath);

            // Десериализуем в список клиентов
            List<Client> clients = JsonConvert.DeserializeObject<List<Client>>(json);

            return clients ?? new List<Client>();
        }

        private void SaveClients(List<Client> clients)
        {
            // Сериализуем список клиентов в JSON
            string json = JsonConvert.SerializeObject(clients, Formatting.Indented);

            // Записываем в файл
            File.WriteAllText(filePath, json);
        }
    }
}
