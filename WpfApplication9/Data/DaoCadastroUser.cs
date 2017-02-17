using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using WpfApplication9.Model;

namespace WpfApplication9.Data
{
   public class DaoCadastroUser:DAO
    {
        //inserir novo usuario
        public int insert_new_user(Usuarios_Model user)
        {
            if (user.login == "" || user.senha == "" || user.chave == "")
            {
                status = 1;
            }
            else
            {
                //Abre conecção
                using (MySqlCommand comando = new MySqlCommand(
                "INSERT INTO usuarios (usuario, senha, chave) " +
                "VALUES " +
                "( " +
                "@Email, " +
                "@Senha, " +
                "@Chave );", conexao))
                {
                    try
                    {
                        if (conexao.State == ConnectionState.Open)
                        {
                            //Se estiver aberta insere os dados na BD
                            comando.Parameters.AddWithValue("@Email", user.login);
                            comando.Parameters.AddWithValue("@Senha", user.senha);
                            comando.Parameters.AddWithValue("@Chave", user.chave);
                            comando.BeginExecuteNonQuery();
                            status = 0;
                        }
                        else
                        {
                            status = 1;
                        }
                    }
                    catch (Exception Erro)
                    {
                        MessageBox.Show("Impossível estabelecer conexão:" + Erro);
                    }
                }
            }
            return status;
        }//insert_new_user
    }
}
