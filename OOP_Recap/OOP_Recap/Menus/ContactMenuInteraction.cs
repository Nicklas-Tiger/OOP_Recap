using OOP_Recap.Models;
using OOP_Recap.Services;
using System.Runtime.CompilerServices;

namespace OOP_Recap.Menus;

internal class ContactMenuInteraction
{
    private ContactService _contactService = new ContactService();
    public void CreateContactPersonMenu()
    {
        var contactPerson = new ContactPerson
        {
            PostalAddress = new Address()
        };

        CreateContactPersonDisplay(contactPerson);

        var result = _contactService.AddContactToList(contactPerson);
        if (result.Succeeded)
        {
            Console.WriteLine($"{result.Message}");
        }
        else
        {
            Console.WriteLine($"{result.Message}");
        }
        Console.ReadKey();
    }
    private void CreateContactPersonDisplay(ContactPerson contactPerson)
    {
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
        contactPerson.PostalAddress!.StreetName = Console.ReadLine();

        Console.Write("Postal Code: ");
        contactPerson.PostalAddress!.PostalCode = Console.ReadLine();

        Console.Write("City: ");
        contactPerson.PostalAddress!.City = Console.ReadLine();
    }
}
