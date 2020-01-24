using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellDemo
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            FlyoutIsPresented = false;
            DisplayAlert("Rate !!", "You selected Rate this app item ", "ok");
        }
    }
}
