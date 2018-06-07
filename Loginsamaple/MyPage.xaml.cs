using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Loginsamaple
{
    public partial class MyPage : ContentPage
    {
        async void Signup_Clicked_1(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Signup());
        }

        public MyPage()
        {
            InitializeComponent();
        }
        async void Login_Clicked(object sender, System.EventArgs e)
        {
            //var vEmployee = new Employee()
            //{
                
            //    Email = UserName.Text,
            //    // dob = Date.Text
            //};
            //var vList = App.DAUtil.GetAllEmployees();
            var vList1 =App.DAUtil.GetEmployee(UserName.Text);
            var emp = new Employee
            {
                FirstName = vList1[0].FirstName.ToString(),
                LastName = vList1[0].LastName.ToString(),
                Vendor = vList1[0].Vendor.ToString(),
                Location = vList1[0].Location.ToString(),
                Client = vList1[0].Client.ToString(),
                Email = vList1[0].Email.ToString()

            };
            var successpage = new Success();
            successpage.BindingContext = emp;
           
           // UserName.Text = vList1;
                            await Navigation.PushAsync(successpage);
        }
    }
}
