using System.Windows;
using System.Windows.Controls;
using Wpf_Bank_A.Data;

namespace Wpf_Bank_A
{
    public partial class ClientDisplay : Window
    {
        private ModificationType modificationType;
        private ClientMaker clientMaker;
        private string filePath;

        public ClientDisplay(ModificationType modificationType)
        {
            InitializeComponent();
            this.modificationType = modificationType;
            filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "data.json");
            clientMaker = new ClientMaker(filePath);
            ConfigureButtons();
            SetDataContext();
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

        private void SetDataContext()
        {
            DataContext = this;
        }

        public ModificationType CurrentModificationType => modificationType;

        private void LoadClientsToTable(object sender, RoutedEventArgs e)
        {
            TableClients.ItemsSource = clientMaker.LoadClients();
            var seriesConverter = (SeriesVisibilityConverter)Resources["SeriesVisibilityConverter"];
            var numberConverter = (NumberVisibilityConverter)Resources["NumberVisibilityConverter"];
            seriesConverter.ModificationType = ModificationType.Консультант;
            numberConverter.ModificationType = ModificationType.Консультант;
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
                    TableClients.ItemsSource = clientMaker.LoadClients();
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
            if (TableClients.SelectedItem is Client selectedClient)
            {
                EditClientWindow editClientWindow = new EditClientWindow(selectedClient);
                if (editClientWindow.ShowDialog() == true)
                {
                    TableClients.ItemsSource = clientMaker.LoadClients();
                    TableClients.Items.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите клиента для редактирования.");
            }
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            AddClientWindow addClientWindow = new AddClientWindow();
            if (addClientWindow.ShowDialog() == true)
            {
                TableClients.ItemsSource = clientMaker.LoadClients();
                TableClients.Items.Refresh();
            }
        }

        private void GoToMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
