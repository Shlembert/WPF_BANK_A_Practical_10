using System;
using System.Windows;
using System.Windows.Controls;
using Wpf_Bank_A.Data;

namespace Wpf_Bank_A
{
    public partial class ClientDisplay : Window
    {
        private IUser user;
        private ClientMaker clientMaker;
        private string filePath;

        public ClientDisplay(ModificationType modificationType)
        {
            InitializeComponent();
            filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "data.json");
            clientMaker = new ClientMaker(filePath);

            if (modificationType == ModificationType.Консультант)
            {
                user = new Consultant();
                ChangePhoneNumberButton.Visibility = Visibility.Visible;
            }
            else if (modificationType == ModificationType.Менеджер)
            {
                user = new Manager();
                EditClientButton.Visibility = Visibility.Visible;
                AddClientButton.Visibility = Visibility.Visible;
            }

            LoadClientsToTable(null, null);
        }

        private void LoadClientsToTable(object sender, RoutedEventArgs e)
        {
            TableClients.ItemsSource = clientMaker.LoadClients();
        }

        private void TableClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Логика обработки изменения выбранного клиента, если нужно
        }

        private void ChangePhoneNumber_Click(object sender, RoutedEventArgs e)
        {
            if (TableClients.SelectedItem is Client selectedClient)
            {
                ChangePhoneNumberWindow changePhoneNumberWindow = new ChangePhoneNumberWindow(selectedClient, user);
                if (changePhoneNumberWindow.ShowDialog() == true)
                {
                    LoadClientsToTable(null, null);
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
                    LoadClientsToTable(null, null);
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
                LoadClientsToTable(null, null);
                TableClients.Items.Refresh();
            }
        }

        private void GoToMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void TableClients_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            if (e.Row.DataContext is Client client)
            {
                if (user is Consultant)
                {
                    client.PassportSeries = new string('*', client.PassportSeries.Length);
                    client.PassportNumber = new string('*', client.PassportNumber.Length);
                }
            }
        }
    }
}
