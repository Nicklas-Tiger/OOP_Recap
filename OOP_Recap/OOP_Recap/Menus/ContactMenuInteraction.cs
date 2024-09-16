using OOP_Recap.Models;
using OOP_Recap.Services;

namespace OOP_Recap.Menus;

internal class ContactMenuInteraction
{
    public void CreateContactPersonMenu()
    {
    
        var contactService = new ContactService();
        var contactPerson = new ContactPerson
        {
            PostalAddress = new Address()
        };

        Console.WriteLine("Create a Contact Person!");
        Console.Write("First name: ");
        contactPerson.FirstName = Console.ReadLine();

        Console.Write("Last name: ");
        contactPerson.LastName = Console.ReadLine();

        Console.Write("Email-address: ");
        contactPerson.Email = Console.ReadLine();

        Console.Write("Phone number: ");
        contactPerson.PhoneNumber = Console.ReadLine();


        Console.Write("Street Name: ");
        contactPerson.PostalAddress.StreetName = Console.ReadLine();

        Console.Write("Postal Code: ");
        contactPerson.PostalAddress.PostalCode = Console.ReadLine();

        Console.Write("City: ");
        contactPerson.PostalAddress.City = Console.ReadLine();

        var result = contactService.AddContactToList(contactPerson);
        if (result)
        {
            Console.WriteLine("Contact Person was added to the directory!");
        }
        else
        {
            Console.WriteLine("Contact Person was not added!");
        }
        Console.ReadKey();



    }
}
