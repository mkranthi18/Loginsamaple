using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SQLite;
using SQLite.Net;
using SQLite.Net.Attributes;

namespace Loginsamaple
{
    public partial class Signup : ContentPage
    {
        async void SubmitCancel(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MyPage());
        }

        async void SubmitSuccess(object sender, System.EventArgs e)
        {
            var vEmployee = new Employee()
            {
                FirstName =FirstName.Text,
                LastName = LastName.Text,
                Email = Email.Text,
                Location = Location.Text,
                Client = Client.Text,
                Vendor = Vendor.Text,
               // dob = Date.Text
            };
            App.DAUtil.SaveEmployee(vEmployee);
            //

            await Navigation.PushAsync(new MyPage());
        }

        public Signup()
        {
            InitializeComponent();
        }
    }

    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
