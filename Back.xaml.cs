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
   
    public sealed partial class Back : Page
    {
        public Back()
        {
            this.InitializeComponent();
            AddTextContent();
        }

        public void AddTextContent()
        {
            Welcome.Text = "YOUR BACK WORKOUT \n";

            Exercise1.Text = "10 BOTTOM TO HEELS STRETCHES";
            Exercise2.Text = "10 OPPOSITE ARM / LEG RAISES";
            Exercise3.Text = "10 BACK EXTENSIONS";
            Exercise4.Text = "10 BRIDGES";
            Exercise5.Text = "10 KNEE ROLLS";
            Exercise6.Text = "";
            Exercise7.Text = "REPEAT 3 TIMES";
            Exercise8.Text = "(TWO MINUTE REST BETWEEN)";
        }

        private void Home_Click(object sender, RoutedEventArgs e)
            {
                this.Frame.Navigate(typeof(MainPage), null);
            }
        }
    }
