using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WCFClientConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BttnToFohrenheit_OnClick(object sender, RoutedEventArgs e)
        {
            using (var client = new WCFClientConverter.WCFClientConvertor.ConverterClient("BasicHttpBinding_IConverter"))
            {
                try
                {
                    var rezult = client.CelsiumToFohrenheit(Convert.ToDouble(txtBxCelsium.Text));
                    txtBxFohrenheitAnswer.Text = rezult.fohrenheit.ToString();
                }
                catch (Exception ex)
                {
                    txtBxFohrenheitAnswer.Text = "Incorrect format";
                }



            }
        }

        private void BttnToCelsium_OnClick(object sender, RoutedEventArgs e)
        {
            using (var client = new WCFClientConverter.WCFClientConvertor.ConverterClient("BasicHttpBinding_IConverter"))
            {
                try
                {
                    var rezult = client.FohrenheitToCelsium(Convert.ToDouble(txtBxFohrenheit.Text));

                    txtBxCelsiumAnswer.Text = rezult.celsius.ToString();
                }
                catch (Exception ex)
                {
                    txtBxCelsiumAnswer.Text = "Incorrect format";
                }

            }
        }

        private void BttnToEnglishMetric_OnClick(object sender, RoutedEventArgs e)
        {
            using (var client = new WCFClientConverter.WCFClientConvertor.ConverterClient("BasicHttpBinding_IConverter"))
            {
                try
                {
                    var rezult = client.LinearMeasure(Convert.ToDouble(txtBxMeter.Text));

                    txtBxYard.Text = rezult.yard.ToString();
                    txtBxFeet.Text = rezult.foot.ToString();
                    txtBxInch.Text = rezult.inch.ToString();
                }
                catch (Exception ex)
                {
                    txtBxYard.Text= txtBxFeet.Text = txtBxInch.Text = "Incorrect format";
                }

            }
        }
    }
}
