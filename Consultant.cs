using Wpf_Bank_A.Data;

public class Consultant : IUser
{
    public void ChangeClientPhoneNumber(Client client, string newPhoneNumber)
    {
        client.PhoneNumber = newPhoneNumber;
        client.LastModificationDateTime = DateTime.Now;
        client.ModificationType = ModificationType.Консультант;
    }

    public void EditClient(Client client, string fullName, string phoneNumber, string passportSeries, string passportNumber)
    {
        throw new InvalidOperationException("Consultants cannot edit client information other than the phone number.");
    }
}
