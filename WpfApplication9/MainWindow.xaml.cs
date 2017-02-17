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
using WpfApplication9.Data;

using WpfApplication9.Model;

namespace WpfApplication9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DaoLogin cadastro;
        public Usuarios_Model log_user;
        public popup_ERRO pg_erro;
        public esquecu_senha senha_help;
        public bool btn = true;
        public MainWindow()
        {
            log_user = new Usuarios_Model();
       
          
            InitializeComponent();

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void bnt_close_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
            cadastro.conexao.Close();
        }

        private void bnt_res_Click(object sender, RoutedEventArgs e)
        {
            if (btn == true)
            {
                this.WindowState = WindowState.Normal;
                btn = false;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                btn = true;
            }
        }

        private void bnt_min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void logar_Click(object sender, RoutedEventArgs e)
        {
            Cad_menu tela_menu_log = new Cad_menu();
            log_user.login = usuario.Text;
            log_user.senha = log_pass.Password;
            if (log_user.login == "" || log_user.senha == "")
            {
                pg_erro = new popup_ERRO("Usuario ou Senha inválida");
                pg_erro.Show();
            }
            else
            {

                cadastro = new DaoLogin();
                cadastro.login_check(log_user);
                if (cadastro.status == 0)
                {
                    this.Close();
                    tela_menu_log.Show();
                }
                else
                {
                    // logar.IsEnabled = false;
                    pg_erro = new popup_ERRO("Erro ao Logar");
                    pg_erro.Show();
                }
            }
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            senha_help = new esquecu_senha();
            senha_help.Show();
        }
    }
}


