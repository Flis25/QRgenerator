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
using QRCoder;
using QRCoder.Xaml;
namespace QRgenerator
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Tlacitko_Click(object sender, RoutedEventArgs e)
        {
            string zadanyText = textImput.Text;
            
            //vytovření generátoru QRcode.
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            //vytvoření dat QrCode.
            QRCodeData dataQrkodu = qRCodeGenerator.CreateQrCode(zadanyText, QRCodeGenerator.ECCLevel.M);

            //vytvoření QRcode s daty.
            XamlQRCode qrKod = new XamlQRCode(dataQrkodu);

            DrawingImage vkladanyObraz = qrKod.GetGraphic(30);
            obrazekQR.Source = vkladanyObraz;

        }
    }
}
