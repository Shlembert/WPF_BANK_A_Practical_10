using System.Windows;
using System.Windows.Controls;
using Wpf_Bank_A.Data;

namespace Wpf_Bank_A
{
    public partial class ClientDisplay : Window
    {
        private ModificationType modificationType;

        public ClientDisplay(ModificationType modificationType)
        {
            InitializeComponent();
            this.modificationType = modificationType;
            ConfigureButtons();
        }

        private void ConfigureButtons()
        {
            if (modificationType == ModificationType.Консультант)
            {
                ChangePhoneNumberButton.Visibility = Visibility.Visible;
                EditClientButton.Visibility = Visibility.Collapsed;
                AddClientButton.Visibility = Visibility.Collapsed;
            }
            else if (modificationType == ModificationType.Менеджер)
            {
                ChangePhoneNumberButton.Visibility = Visibility.Collapsed;
                EditClientButton.Visibility = Visibility.Visible;
                AddClientButton.Visibility = Visibility.Visible;
            }
        }

        private void LoadClientsToTable(object sender, RoutedEventArgs e)
        {
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "data.json");
            ClientMaker clientMaker = new(filePath);
            TableClients.ItemsSource = clientMaker.LoadClients();
        }

        private void TableClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Обработка выбора строки
        }

        private void ChangePhoneNumber_Click(object sender, RoutedEventArgs e)
        {
            if (TableClients.SelectedItem is Client selectedClient)
            {
                ChangePhoneNumberWindow changePhoneNumberWindow = new ChangePhoneNumberWindow(selectedClient);
                if (changePhoneNumberWindow.ShowDialog() == true)
                {
                    // Обновляем данные в таблице после смены номера телефона
                    TableClients.Items.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Выберите клиента для смены телефона.");
            }
        }


        private void EditClient_Click(object sender, RoutedEventArgs e)
        {
            // Обработка редактирования клиента
            if (TableClients.SelectedItem is Client selectedClient)
            {
                // Открыть окно для редактирования клиента
            }
            else
            {
                MessageBox.Show("Выберите клиента для редактирования.");
            }
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            // Обработка добавления нового клиента
            // Открыть окно для добавления клиента
        }

        private void GoToMenu_Click(object sender, RoutedEventArgs e)
        {
            // Возврат в меню
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
