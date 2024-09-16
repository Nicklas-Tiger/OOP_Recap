using OOP_Recap.Models;
using System.Diagnostics;

namespace OOP_Recap.Services;

public class ContactService
{
    private List<ContactPerson> _contacts = [];

    public ResponseResult AddContactToList(ContactPerson contactPerson)
    {
        try
        {
            if (!_contacts.Any(x => x.Email == contactPerson.Email))
            {
                _contacts.Add(contactPerson);
                return new ResponseResult { Succeeded = true, Message = "Contact Person was added successfully!"};
            }
            return new ResponseResult { Succeeded = false, Message = "A Contact Person with the same e-mail address already exists." };
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"ERROR: {ex.Message}!");
            return new ResponseResult { Succeeded = false, Message = "Something went wrong. Contact Person was not added!" };
        }
    }
}
