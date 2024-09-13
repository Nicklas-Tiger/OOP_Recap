using OOP_Recap.Models;
using System.Diagnostics;

namespace OOP_Recap.Services;

public class ContactService
{
    private List<ContactPerson> _contacts = [];
    public void AddContactToList(ContactPerson contactPerson)
    {
        try
        {
            _contacts.Add(contactPerson);
        }
        catch
        (Exception ex)
        {
            Debug.WriteLine($"Error: {ex.Message}!");
        }


    }
}
