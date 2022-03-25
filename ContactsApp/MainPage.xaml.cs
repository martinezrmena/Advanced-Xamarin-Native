using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContactsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            IContact contact = DependencyService.Get<IContact>();
            string hello = contact.HelloContact();
            greetingLabel.Text = hello;
        }
    }
}
