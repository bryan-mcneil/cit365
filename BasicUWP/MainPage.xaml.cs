using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BasicUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            List<string> tints = new List<string>();
            tints.Add("Black");
            tints.Add("Blue");
            tints.Add("Brown");
            comboTint.ItemsSource = tints;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double width = Convert.ToDouble(textBoxWidth.Text);
            double height = Convert.ToDouble(textBoxHeight.Text);
            int quantity = Convert.ToInt32(quantitySlider.Value);


            double woodLength = 2 * (width + height) * 3.25;
            double glassArea = 2 * (width * height);

            var messageDialog = new MessageDialog("Width: " + width + "\nHeight: " + height + "\nTint: " + comboTint.SelectedItem 
                + "\nQuantity: " + quantity + "\nWood Length: " + woodLength + "\tGlass Area: " + glassArea + "\nDate Created: " + DateTime.Today);
            messageDialog.ShowAsync();

        }

        private void textBoxWidth_KeyUp_1(object sender, KeyRoutedEventArgs e)
        {
            int i = 0;

            if (textBoxWidth.Text != "")
            {
                if (!Regex.IsMatch(e.Key.ToString(), @"/^\d*\.?\d*$/"))
                {
                    var messageDialog = new MessageDialog("Please enter a number");
                    messageDialog.ShowAsync();
                    textBoxWidth.Text = "";
                }
            }
        }

        private void textBoxHeight_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            int i = 0;

            if (textBoxHeight.Text != "")
            {
                if (!int.TryParse(textBoxHeight.Text, out i))
                {
                    var messageDialog = new MessageDialog("Please enter a number");
                    messageDialog.ShowAsync();
                    textBoxHeight.Text = "";
                }
            }
        }
    }
}
