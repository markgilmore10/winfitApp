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
   
    public sealed partial class Thigh : Page
    {
        public Thigh()
        {
            this.InitializeComponent();
            AddTextContent();
        }

        public void AddTextContent()
        {
            Welcome.Text = "YOUR THIGH WORKOUT \n";

            Exercise1.Text = "10 TOE TOUCHES (STANDING)";
            Exercise2.Text = "10 RIGHT LEG LUNGES";
            Exercise3.Text = "10 LEFT LEG LUNGES";
            Exercise4.Text = "30 SQUATS";
            Exercise5.Text = "40 JUMPING JACKS";
            Exercise6.Text = "50 TOE TOUCHES (SITTING)";
            Exercise7.Text = "1 MINUTE WALL SIT";
            
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }
    }
}
