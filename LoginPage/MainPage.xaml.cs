using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginPage
{
    public partial class MainPage : ContentPage
    {

       
        public MainPage()
        {
            InitializeComponent();

            // Başlangıçta parola açık şekilde ayarlanır
            EntryPassword.IsPassword = false;
            CheckBox.IsChecked = true;

            // CheckBox CheckedChanged olayı tetiklenerek parola gizliliği ayarlanır
            CheckBox.CheckedChanged += (s, e) =>
            {
                EntryPassword.IsPassword = !CheckBox.IsChecked;
            };

          
        }


        private void ForgotPasswordButton_Clicked(object sender, EventArgs e)
        {

        }

        private void SigUpButton_Clicked(object sender, EventArgs e)
        {

        }

        private void LogInButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
