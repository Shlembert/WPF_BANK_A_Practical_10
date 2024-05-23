using System;
using System.Windows;
using Wpf_Bank_A.Data;

namespace Wpf_Bank_A
{
    public partial class EditClientWindow : Window
    {
        private Client selectedClient;

        public EditClientWindow(Client client)
        {
            InitializeComponent();
            selectedClient = client;
            FullNameTextBox.Text = selectedClient.FullName;
            PhoneNumberTextBox.Text = selectedClient.PhoneNumber;
            PassportSeriesTextBox.Text = selectedClient.PassportSeries;
            PassportNumberTextBox.Text = selectedClient.PassportNumber;
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
            if (string.IsNullOrWhiteSpace(FullNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(PhoneNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(PassportSeriesTextBox.Text) ||
                string.IsNullOrWhiteSpace(PassportNumberTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            selectedClient.FullName = FullNameTextBox.Text;
            selectedClient.PhoneNumber = PhoneNumberTextBox.Text;
            selectedClient.PassportSeries = PassportSeriesTextBox.Text;
            selectedClient.PassportNumber = PassportNumberTextBox.Text;
            selectedClient.LastModificationDateTime = DateTime.Now;
            selectedClient.ModificationType = ModificationType.Менеджер;

            SaveClientChanges(selectedClient);

            DialogResult = true;
            Close();
        }

        private void SaveClientChanges(Client client)
        {
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "data.json");
            ClientMaker clientMaker = new ClientMaker(filePath);
            clientMaker.SaveClient(client);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
