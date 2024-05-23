using System;
using System.Windows;
using Wpf_Bank_A.Data;

namespace Wpf_Bank_A
{
    public partial class ChangePhoneNumberWindow : Window
    {
        private Client selectedClient;
        private IUser user;

        public ChangePhoneNumberWindow(Client client, IUser user)
        {
            InitializeComponent();
            selectedClient = client;
            this.user = user;
            ClientFullNameTextBlock.Text = selectedClient.FullName;
            PhoneNumberTextBox.Text = selectedClient.PhoneNumber;
        }

        private void PhoneNumberTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PhoneNumberTextBox.Clear();
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            string newPhoneNumber = PhoneNumberTextBox.Text;

            // Обновляем только номер телефона у клиента
            selectedClient.PhoneNumber = newPhoneNumber;

            // Устанавливаем автора изменения на "Консультант"
            selectedClient.ModificationType = ModificationType.Консультант;

            // Сохраняем изменения только номера телефона
            SaveClientPhoneNumberChange(selectedClient);

            DialogResult = true;
            Close();
        }

        private void SaveClientPhoneNumberChange(Client client)
        {
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "data.json");
            ClientMaker clientMaker = new ClientMaker(filePath);
            clientMaker.SaveClientPhoneNumberChange(client);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
