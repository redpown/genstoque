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
using System.Windows.Shapes;
using WpfApplication9.Data;
using WpfApplication9.Model;
namespace WpfApplication9
{
    /// <summary>
    /// Interaction logic for New_User.xaml
    /// </summary>
    public partial class New_User : Window
    {
        public DaoCadastroUser cadastro;
        public Usuarios_Model user_log;
        public popup_ERRO pg_erro;
        public bool btn = true;
        public Cad_menu menu_principal;
        public New_User()
        {
           cadastro = new DaoCadastroUser();
            user_log = new Usuarios_Model();
            InitializeComponent();
            
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void bnt_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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


        private void voltar_Click(object sender, RoutedEventArgs e)
        {
            menu_principal = new Cad_menu();
            this.Close();
            menu_principal.Show();
        }

        private void inseir_Click(object sender, RoutedEventArgs e)
        {
            user_log.login = user_email.Text;
            user_log.senha = user_senha.Text;
            user_log.chave = user_chave.Text;
            cadastro.insert_new_user(user_log);
         
            if (cadastro.status == 0)
            {
                pg_erro = new popup_ERRO("Usuario "+ user_email.Text +"\n Inserido com Sucesso");
                pg_erro.Show();
            }
            else
            {
                // logar.IsEnabled = false;
                pg_erro = new popup_ERRO("Erro ao Inserir Novo Usario");
                pg_erro.Show();
            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            user_log.login = user_email.Text;
            user_log.senha = user_senha.Text;
            user_log.chave = user_chave.Text;
            cadastro.update_user(user_log);
            if (cadastro.status == 0)
            {
                pg_erro = new popup_ERRO("Usuario " + user_email.Text + "\n Atualizado com Sucesso");
                pg_erro.Show();
            }
            else
            {
                // logar.IsEnabled = false;
                pg_erro = new popup_ERRO("Erro ao Inserir Novo Usario");
                pg_erro.Show();
            }
        }

        private void deletar_Click(object sender, RoutedEventArgs e)
        {
            user_log.login = user_email.Text;
            user_log.senha = user_senha.Text;
            user_log.chave = user_chave.Text;
            cadastro.delete_user(user_log);
            if (cadastro.status == 0)
            {
                pg_erro = new popup_ERRO("Usuario " + user_email.Text + "\n Deletado com Sucesso");
                pg_erro.Show();
            }
            else
            {
                // logar.IsEnabled = false;
                pg_erro = new popup_ERRO("Erro ao Inserir Novo Usario");
                pg_erro.Show();
            }
        }
    }
}
