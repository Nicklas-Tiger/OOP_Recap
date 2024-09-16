using OOP_Recap.Models;
using OOP_Recap.Services;
    public class UnitTests
    {
    [Fact]
        public void AddDuplicateContactPersons__Should_NotAddContactPersonToList__ReturnFalse()
    {
        //arrange - förberedelser - vi instansierar objektet och vår service
            var contactService = new ContactService();
            var contactPerson = new ContactPerson
            {
            Email = "nicklas.tiger@gmail.com",
            };
        contactService.AddContactToList(contactPerson);

        //act - utför jsälva handlingen!
        var result = contactService.AddContactToList(contactPerson);

        //Assert - resultatet
        Assert.False(result.Succeeded);
        Assert.Equal("A Contact Person with the same e-mail address already exists.", result.Message);
    }

        }
    
/*
 *         [Fact]
        public void AddContactToList__Should_AddContactPersonToList__ReturnTrue()
        {
            //arrange - förberedelser - vi instansierar objektet och vår service
            var contactService = new ContactService();
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

            //act - utför jsälva handlingen!
            var result = contactService.AddContactToList(contactPerson);

            //Assert - resultatet
            Assert.True(result.Succeeded);
*/