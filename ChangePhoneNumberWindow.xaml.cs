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
            user.ChangeClientPhoneNumber(selectedClient, newPhoneNumber);
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
