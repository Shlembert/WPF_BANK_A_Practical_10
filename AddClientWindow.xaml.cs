using System.Windows;
using Wpf_Bank_A.Data;

namespace Wpf_Bank_A
{
    public partial class AddClientWindow : Window
    {
        public AddClientWindow()
        {
            InitializeComponent();
        }

        private void FullNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            FullNameTextBox.Clear();
        }

        private void PhoneNumberTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PhoneNumberTextBox.Clear();
        }

        private void PassportSeriesTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PassportSeriesTextBox.Clear();
        }

        private void PassportNumberTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PassportNumberTextBox.Clear();
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем, что поля заполнены
            if (string.IsNullOrWhiteSpace(FullNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(PhoneNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(PassportSeriesTextBox.Text) ||
                string.IsNullOrWhiteSpace(PassportNumberTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            // Создаем нового клиента
            Client newClient = new Client(FullNameTextBox.Text, 
                                          PhoneNumberTextBox.Text, 
                                          PassportSeriesTextBox.Text, 
                                          PassportNumberTextBox.Text, 
                                          ModificationType.Менеджер);

            // Сохраняем нового клиента
            SaveClient(newClient);

            // Закрываем окно
            DialogResult = true;
            Close();
        }

        private void SaveClient(Client client)
        {
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "data.json");
            ClientMaker clientMaker = new ClientMaker(filePath);
            clientMaker.SaveClient(client);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Закрываем окно без изменений
            DialogResult = false;
            Close();
        }
    }
}
