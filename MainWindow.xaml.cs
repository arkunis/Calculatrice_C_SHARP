using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace vrac
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static List<float> nombre1 = new List<float>();
        static List<float> nombre2 = new List<float>();
        static string operateur = "";
        static float nb1;
        static float nb2;
        static float totalCalcul;
        static bool isCorrect = false;

        public MainWindow()
        {
            InitializeComponent();

        }

        public void chiffre(float value)
        {
            if (operateur == "")
            {
                nombre1.Add(value);
                isCorrect = true;
            }
            else
            {
                nombre2.Add(value);
            }
            total();
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            chiffre(1);
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            chiffre(2);
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            chiffre(3);
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            chiffre(4);
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            chiffre(5);
        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            chiffre(6);
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            chiffre(7);
        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            chiffre(7);
        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            chiffre(9);
        }

        private void _0_Click(object sender, RoutedEventArgs e)
        {
            chiffre(0);
        }

        public void total()
        {
            float total1 = entierNb(nombre1);
            if (operateur != "")
            {
                float total2 = entierNb(nombre2);
                calcul.Content = total1 + operateur + total2;
            }
            else
            {
                calcul.Content = total1;
            }     
        }

        private void _plus_Click(object sender, RoutedEventArgs e)
        {
            operateurSigle("+");
        }

        private void _moins_Click(object sender, RoutedEventArgs e)
        {
            operateurSigle("-");
        }

        private void _multiplier_Click(object sender, RoutedEventArgs e)
        {
            operateurSigle("*");
        }

        private void _diviser_Click(object sender, RoutedEventArgs e)
        {
            operateurSigle("/");
        }

        public void operateurSigle(string sigle)
        {
            if (!isCorrect)
            {
                nombre1.Add(0);
                total();
                operateur = sigle;
                nombre2.Clear();
            }
            else
            {
                operateur = sigle;
            }
        }

        public float entierNb(List<float> val)
        {
            float total = float.Parse(string.Join(",", val).Replace(",", ""));
            return total;
        }

        private void _egale_Click(object sender, RoutedEventArgs e)
        {
            switch(operateur)
            {
                case "+":
                    nb1 = entierNb(nombre1);
                    nb2 = entierNb(nombre2);
                    totalCalcul = nb1 + nb2;
                    calcul.Content = totalCalcul;
                    nombre1.Clear();
                    nombre2.Clear();
                    operateur = "";
                    isCorrect = false;
                    break;
                case "-":
                    nb1 = entierNb(nombre1);
                    nb2 = entierNb(nombre2);
                    totalCalcul = nb1 - nb2;
                    calcul.Content = totalCalcul;
                    nombre1.Clear();
                    nombre2.Clear();
                    operateur = "";
                    isCorrect = false;
                    break;
                case "*":
                    nb1 = entierNb(nombre1);
                    nb2 = entierNb(nombre2);
                    totalCalcul = nb1 * nb2;
                    calcul.Content = totalCalcul;
                    nombre1.Clear();
                    nombre2.Clear();
                    operateur = "";
                    isCorrect = false;
                    break;
                case "/":
                    nb1 = entierNb(nombre1);
                    nb2 = entierNb(nombre2);
                    totalCalcul = nb1 / nb2;
                    calcul.Content = totalCalcul;
                    nombre1.Clear();
                    nombre2.Clear();
                    operateur = "";
                    isCorrect = false;
                    break;
                default:
                    MessageBox.Show("Vous devez choisir un operateur");
                    break;
            }
        }
    }
}