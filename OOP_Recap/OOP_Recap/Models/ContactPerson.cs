namespace OOP_Recap.Models;

public class ContactPerson
{
    public string Id {  get; set; } = Guid.NewGuid().ToString();
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public Address PostalAddress { get; set; } = null!;


}
