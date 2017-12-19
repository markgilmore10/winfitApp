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
    public sealed partial class Waist : Page
    {
        public Waist()
        {
            this.InitializeComponent();
            AddTextContent();
        }

        public void AddTextContent()
        {
            Welcome.Text = "YOUR WAIST WORKOUT \n";

            Exercise1.Text = "10 CRUNCHES";
            Exercise2.Text = "10 BICYCLE CRUNCHES";
            Exercise3.Text = "10 MOUNTAIN CLIMBERS";
            Exercise4.Text = "10 SIDE V-UPS";
            Exercise5.Text = "10 DYNAMIC PLANKS";
            Exercise6.Text = "10 KNEE TOUCHES";
            Exercise7.Text = "10 TOE TOUCHES";
            Exercise8.Text = "10 LEG LIFTS";
            Exercise9.Text = "10 CRUNCH CLAPS";
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }
    }
}
