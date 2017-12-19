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
   
    public sealed partial class Legs : Page
    {
        public Legs()
        {
            this.InitializeComponent();
            AddTextContent();
        }

        public void AddTextContent()
        {
            Welcome.Text = "YOUR LEG WORKOUT \n";

            Exercise1.Text = "20 SQUATS";
            Exercise2.Text = "30 LUNGES";
            Exercise3.Text = "40 CALF RAISES";
            Exercise4.Text = "50 SECOND WALL SIT";
            Exercise5.Text = "100 JUMPING JACKS";
            Exercise6.Text = "50 SECOND WALL SIT";
            Exercise7.Text = "40 SQUATS";
            Exercise8.Text = "30 LEG RAISES";
            Exercise9.Text = "20 JUMP SQUATS";
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }
    }
}
