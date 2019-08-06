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

namespace WpfApp.views
{
    /// <summary>
    /// Interação lógica para UcLogin.xam
    /// </summary>
    public partial class UcLogin : UserControl
    {

        public event EventHandler LoginCorreto;
        public UcLogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Teste(txuser.Text, txsenha.Text);
        }

        public void Teste(string login, string senha) {
            if (login == "admin" && senha == "admin")
            {
                this.Visibility = Visibility.Hidden;
                LoginCorreto(null, new EventArgs());
            }
            else
                MessageBox.Show("Login inválido!",
                                "Atenção",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);            
        }

        private void BtLogin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
