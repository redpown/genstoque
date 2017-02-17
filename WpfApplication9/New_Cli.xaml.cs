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
    /// Interaction logic for New_Cli.xaml
    /// </summary>
    public partial class New_Cli : Window
    {
        public DaoCadastroEmpresa cadastro;
        public Clientes_Model cli;
        public popup_ERRO pg_erro;
        public bool btn = true;
        public Cad_menu menu_principal;
        public New_Cli()
        {
            cli = new Clientes_Model();
           
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
            cli.cod = campo_cod.Text;
            cli.nome = campo_nome.Text;
            cli.endereco = campo_endereco.Text;
            cli.bairro = campo_bairro.Text;
            cli.cidade = comboBox_cidade.SelectionBoxItem.ToString();
            cli.uf = comboBox_uf.SelectionBoxItem.ToString();
            cli.cep = campo_cep.Text;
            cli.senha = campo_senha.Text;
            cli.repit_senha = campo_repetir_senha.Text;
            cli.email = campo_email.Text;
            cli.tipo = comboBox_tipo_pessoas.SelectionBoxItem.ToString();
            cli.tel = campo_tel.Text;
            cli.cel = campo_cel.Text;
            cadastro = new DaoCadastroEmpresa();
            cadastro.insert_new_Empresa(cli);
            if (cadastro.status == 0)
            {
                pg_erro = new popup_ERRO("Empresa " + cli.nome + "\n Inserido com Sucesso");
                pg_erro.Show();
            }
            else
            {
                // logar.IsEnabled = false;
                pg_erro = new popup_ERRO("Erro ao Inserir Nova Empresa");
                pg_erro.Show();
            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            cli.cod = campo_cod.Text;
            cli.nome = campo_nome.Text;
            cli.bairro = campo_bairro.Text;
            cli.cidade = comboBox_cidade.SelectionBoxItem.ToString();
            cli.uf = comboBox_uf.SelectionBoxItem.ToString();
            cli.cep = campo_cep.Text;
            cli.senha = campo_senha.Text;
            cli.repit_senha = campo_repetir_senha.Text;
            cli.email = campo_email.Text;
            cli.tipo = comboBox_tipo_pessoas.SelectionBoxItem.ToString();
            cli.tel = campo_tel.Text;
            cli.cel = campo_cel.Text;

            cadastro = new DaoCadastroEmpresa();

            cadastro.update_Empresa(cli); 
            if (cadastro.status == 0)
            {
                pg_erro = new popup_ERRO("Empresa " + cli.nome + "\n Atualizado com Sucesso");
                pg_erro.Show();
            }
            else
            {
                // logar.IsEnabled = false;
                pg_erro = new popup_ERRO("Erro ao Inserir Nova Empresa");
                pg_erro.Show();
            }
        }

        private void deletar_Click(object sender, RoutedEventArgs e)
        {
            cli.cod = campo_cod.Text;
            cli.nome = campo_nome.Text;
            cli.bairro = campo_bairro.Text;
            cli.cidade = comboBox_cidade.SelectionBoxItem.ToString();
            cli.uf = comboBox_uf.SelectionBoxItem.ToString();
            cli.cep = campo_cep.Text;
            cli.senha = campo_senha.Text;
            cli.repit_senha = campo_repetir_senha.Text;
            cli.email = campo_email.Text;
            cli.tipo = comboBox_tipo_pessoas.SelectionBoxItem.ToString();
            cli.tel = campo_tel.Text;
            cli.cel = campo_cel.Text;

            cadastro = new DaoCadastroEmpresa();

            cadastro.delete_Empresa(cli);
            if (cadastro.status == 0)
            {
                pg_erro = new popup_ERRO("Empresa " + cli.nome + "\n Deletado com Sucesso");
                pg_erro.Show();
            }
            else
            {
                // logar.IsEnabled = false;
                pg_erro = new popup_ERRO("Erro ao Inserir Nova Empresa");
                pg_erro.Show();
            }
        }

        private void CodGenarator(object sender, TextCompositionEventArgs e)
        {
            Random cod = new Random();
            int  Num0 ,Num1, Num2, Num3, Num4, Num5, Num6, Num7, Num8, Num9;
            Num0 = cod.Next();
            Num1 = cod.Next();
            Num2 = cod.Next();
            Num3 = cod.Next();
            Num4 = cod.Next();
            Num5 = cod.Next();
            Num6 = cod.Next();
            Num7 = cod.Next();
            Num8 = cod.Next();
            Num9 = cod.Next();

            campo_cod.Text = (Num1).ToString();        }

        private void CodGenarator(object sender, MouseEventArgs e)
        {
            Random cod = new Random();
            StringBuilder cod_get = new StringBuilder();
            for (int i = 0; i < 9; i++) {
                cod_get.Append(cod.Next(0,9));
            }
            campo_cod.Text = cod_get.ToString();
        }
    }
}
