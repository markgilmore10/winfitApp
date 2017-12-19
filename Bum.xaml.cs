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
  
    public sealed partial class Bum : Page
    {
        public Bum()
        {
            this.InitializeComponent();
            AddTextContent();
        }

        public void AddTextContent()
        {
            Welcome.Text = "YOUR BUM WORKOUT \n";

            Exercise1.Text = "15 RIGHT LEG DONKEY KICKS";
            Exercise2.Text = "15 LEFT LEG DONKEY KICKS";
            Exercise3.Text = "15 BRIDGES";
            Exercise4.Text = "15 RIGHT LEG FORWARD LUNGES";
            Exercise5.Text = "15 LEFT LEG FORWARD LUNGES";
            Exercise6.Text = "15 SQUATS";
            Exercise7.Text = "15 PILE SQUATS";
            Exercise8.Text = "30 SIDE LUNGES \n (15 RIGHT / 15 LEFT)";
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }
    }
}
