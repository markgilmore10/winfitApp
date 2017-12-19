using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WinFitApp
{
   
    public sealed partial class Arms : Page
    {

        public Arms()
        {
            this.InitializeComponent();
            AddTextContent();
        }

        public void AddTextContent()
        {
            Welcome.Text = "YOUR ARMS WORKOUT \n";

            Exercise1.Text = "12 STANDING BICEP CURLS \n (EACH ARM)";
            Exercise2.Text = "10 PUSH-UPS";
            Exercise3.Text = "10 RIGHT ARM BICEP CURLS";
            Exercise4.Text = "10 LEFT ARM BICEP CURLS";
            Exercise5.Text = "30 SECOND REST";
            Exercise6.Text = "10 TRICEP KICKBACKS";
            Exercise7.Text = "10 PUSH-UPS";
            Exercise8.Text = "12 STANDING BICEP CURLS \n (EACH ARM)";
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

       
    }
}
