using CipherPermutation;
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

namespace CipherPermutationWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Transposition transposition { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            transposition= new Transposition();
        }

        private void EncryptButton_Click(object sender, RoutedEventArgs e)
        {
            transposition.SetKey(KeyBox.Text);
            EncrypBox.Text = transposition.Encrypt(DecryptBox.Text);
        }

        private void DecryptButton_Click(object sender, RoutedEventArgs e)
        {
            transposition.SetKey(KeyBox.Text);
            DecryptBox.Text = transposition.Decrypt(EncrypBox.Text);
        }
    }
}
