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

namespace KruhXaml
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        
    }

        private void Button_Click(object sender, RoutedEventArgs e)

        {
            double polomer;
            double obsah;
            double obvod;
            string jednotka = Vyber_jendotka.Text;
            string jednotka_obsah;
            string jednotka_obvod;
            string str_j_obsah = "0";
            string str_j_obvod = "0";
            string str_obsah;
            string str_obvod;




            double.TryParse(guna.Text, out polomer);
            if (polomer <= 0)
            {
                MessageBox.Show("zadejte jiné číslo");
            }
            obsah = 3.1415 * (polomer * polomer);
            obvod = 3.1415 * polomer * 2;
            str_obsah = obsah.ToString();
            str_obvod = obvod.ToString();


            if (jednotka == "mm")
            {
                jednotka_obsah = "mm²";
                jednotka_obvod = "mm";
                str_j_obsah = jednotka_obsah.ToString();
                str_j_obvod = jednotka_obvod.ToString();

            }
            else if (jednotka == "cm")
            {
                jednotka_obsah = "cm²";
                jednotka_obvod = "cm";
                str_j_obsah = jednotka_obsah.ToString();
                str_j_obvod = jednotka_obvod.ToString();
            }
            else if (jednotka == "dm")
            {
                jednotka_obsah = "dm²";
                jednotka_obvod = "dm";
                str_j_obsah = jednotka_obsah.ToString();
                str_j_obvod = jednotka_obvod.ToString();
            }
            else if (jednotka == "m")
            {
                jednotka_obsah = "m²";
                jednotka_obvod = "m";
                str_j_obsah = jednotka_obsah.ToString();
                str_j_obvod = jednotka_obvod.ToString();
            }
            Vypocet_obsahu.Text = "Obsah je:" + str_obsah + str_j_obsah;
            Vypocet_obvodu.Text = "Obvod je:" + str_obvod + str_j_obvod;
        }
    }
}
