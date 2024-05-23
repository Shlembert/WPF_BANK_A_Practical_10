using Wpf_Bank_A.Data;

public class Manager : IUser
{
    public void ChangeClientPhoneNumber(Client client, string newPhoneNumber)
    {
        client.PhoneNumber = newPhoneNumber;
        client.LastModificationDateTime = DateTime.Now;
        client.ModificationType = ModificationType.Менеджер;
    }

    public void EditClient(Client client, string fullName, string phoneNumber, string passportSeries, string passportNumber)
    {
        client.FullName = fullName;
        client.PhoneNumber = phoneNumber;
        client.PassportSeries = passportSeries;
        client.PassportNumber = passportNumber;
        client.LastModificationDateTime = DateTime.Now;
        client.ModificationType = ModificationType.Менеджер;
    }
}
