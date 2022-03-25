using System;
using ContactsApp.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(Contact))]
namespace ContactsApp.Droid
{
    [Android.Runtime.Preserve (AllMembers = true)]
	public class Contact : IContact
    {
        [Android.Runtime.Preserve(Conditional = true)]
        public Contact()
        {
            //Code I want to preserve
        }

        public string ByeContact()
        {
            Contacts.Contact contact = new Contacts.Contact("Rafael", "Martinez", "lalo@example.com");
            return contact.ByeContact();
        }

        public string HelloContact()
        {
            Contacts.Contact contact = new Contacts.Contact("Rafael", "Martinez", "lalo@example.com");
            return contact.GreetContact();
        }
    }
}
