using Wpf_Bank_A.Data;

public interface IUser
{
    void ChangeClientPhoneNumber(Client client, string newPhoneNumber);
    void EditClient(Client client, string fullName, string phoneNumber, string passportSeries, string passportNumber);
}
