using System;
using ContactsApp.iOS;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(Contact))]
namespace ContactsApp.iOS
{
    [Preserve (AllMembers = true)]
    public class Contact : IContact
    {
        public Contact()
        {
        }

        [Preserve (Conditional = true)]
        public string ByeContact()
        {
            NativeLibrary.ContactsApp contact = new NativeLibrary.ContactsApp((Foundation.NSString)"Eduardo", (Foundation.NSString)"Rosas", (Foundation.NSString)"lalo@example.com");
            return contact.ByeContact();
        }

        public string HelloContact()
        {
            NativeLibrary.ContactsApp contact = new NativeLibrary.ContactsApp((Foundation.NSString)"Eduardo", (Foundation.NSString)"Rosas", (Foundation.NSString)"lalo@example.com");
            return contact.GreetContact();
        }
    }
}
