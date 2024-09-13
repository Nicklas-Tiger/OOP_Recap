using OOP_Recap.Models;
using OOP_Recap.Services;

public class UnitTests
{
    public void MyFirstTest()
    {
        var contactPerson = new ContactPerson
        {
            FirstName = "Nicklas",
            LastName = "Tiger",
            Email = "nicklas.tiger@gmail.com",
            PhoneNumber = "0736 21 36 10",

            PostalAddress = new Address
            {
                StreetName = "Båtbyggargatan 23",
                PostalCode = "120 70",
                City = "Stockholm."
            }
        };

        var contactService = new ContactService();
        contactService.AddContactToList(contactPerson);



    }
}

