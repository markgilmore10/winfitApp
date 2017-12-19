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
  
    public sealed partial class FullBody : Page
    {
        public FullBody()
        {
            this.InitializeComponent();
            AddTextContent();
        }

        public void AddTextContent()
        {
            Welcome.Text = "YOUR FULL BODY WORKOUT \n";

            Exercise1.Text = "20 SQUAT JUMPS";
            Exercise2.Text = "20 LUNGES";
            Exercise3.Text = "20 BURPEES";
            Exercise4.Text = "20 JUMPING JACKS";
            Exercise5.Text = "30 SECOND REST";
            Exercise6.Text = "20 SQUATS";
            Exercise7.Text = "20 CRUNCHES";
            Exercise8.Text = "REPEAT 3 TIMES";
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }
    }
}
