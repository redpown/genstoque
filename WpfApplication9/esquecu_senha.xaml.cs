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
    /// Interaction logic for esquecu_senha.xaml
    /// </summary>
    public partial class esquecu_senha : Window
    {
        public Usuarios_Model log_user;
        public DAO reset_senha;
        public Cad_menu menu_principal;
        public popup_ERRO pg_erro;
        public esquecu_senha()
        {
           
            log_user = new Usuarios_Model();
            InitializeComponent();
        }
        private void bnt_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void voltar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void update_Click(object sender, RoutedEventArgs e)
        {
            log_user.login = user_email.Text;
            log_user.senha = user_senha.Text;
            log_user.chave = user_chave.Text;
            reset_senha = new DAO();
            reset_senha.update_user(log_user);
            if (reset_senha.status == 0)
            {
                pg_erro = new popup_ERRO("Usuario " + log_user.login + "\n Atualizado com Sucesso");
                pg_erro.Show();
              
            }
            else
            {
                // logar.IsEnabled = false;
                pg_erro = new popup_ERRO("Erro ao Atualizar senha");
                pg_erro.Show();
               
              
            }
        }
    }
}
