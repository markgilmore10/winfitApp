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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BMI : Page
    {
        public BMI()
        {
            this.InitializeComponent();
            AddTextContent();
        }

        public void AddTextContent()
        {
            Welcome.Text = "YOUR BMI CALCULATOR \n";
        }

            private void button_Click(object sender, RoutedEventArgs e)
        {
            var weight = Convert.ToDecimal(textBox1.Text);
            var height = Convert.ToDecimal(textBox2.Text);

            var bmi = weight / (height * height);
            var bmi1 = String.Format("{0:0.00}", bmi);

            textBox3.Text = bmi1;

        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

      
    }


}
