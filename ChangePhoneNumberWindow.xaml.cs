using System.Windows;
using Wpf_Bank_A.Data;

namespace Wpf_Bank_A
{
    public partial class ChangePhoneNumberWindow : Window
    {
        private Client selectedClient;

        public ChangePhoneNumberWindow(Client client)
        {
            InitializeComponent();
            selectedClient = client;
            ClientFullNameTextBlock.Text = selectedClient.FullName;
            PhoneNumberTextBox.Text = selectedClient.PhoneNumber;
        }

        private void PhoneNumberTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Очищаем поле ввода при фокусировке
            PhoneNumberTextBox.Clear();
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем новый номер телефона из TextBox
            string newPhoneNumber = PhoneNumberTextBox.Text;

            // Проверка на корректность номера телефона (по желанию)

            // Обновляем номер телефона клиента
            selectedClient.PhoneNumber = newPhoneNumber;

            // Сохраняем изменения
            SaveClientChanges(selectedClient);

            // Закрываем окно
            DialogResult = true;
            Close();
        }


        private void SaveClientChanges(Client client)
        {
            // Создаем объект ClientMaker для работы с данными
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "data.json");
            ClientMaker clientMaker = new ClientMaker(filePath);

            // Сохраняем измененного клиента
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
