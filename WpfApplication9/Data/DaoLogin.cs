using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using WpfApplication9.Model;
using System.Windows;

namespace WpfApplication9.Data
{
   public class DaoLogin:DAO
    {
        public int login_check(Usuarios_Model user)
        {
            if (user.login == "" || user.login == "")
            {
                 status = 1;
            }
            else
            {
                //Abre conecção
                using (MySqlCommand comando = new MySqlCommand(
                    "SELECT id " +
                    "FROM usuarios " +
                    "where " +
                    "usuario = @Email and " +
                    "senha = @Senha;", conexao))
                {
                    try
                    {
                        if (conexao.State == ConnectionState.Open)
                        {
                            //Se estiver aberta procura os dados na BD
                            // comando.Parameters.AddWithValue("@Nome", nome.Text);// para sql usar .Parameters.Add
                            comando.Parameters.AddWithValue("@Email", user.login);
                            comando.Parameters.AddWithValue("@Senha", user.senha);
                            comando.BeginExecuteNonQuery();
                            reader = comando.ExecuteReader();
                            if (reader.HasRows)
                            {
                                status = 0;
                            }
                            else
                            {
                                status = 1;
                            }
                        }
                    }
                    catch (Exception Erro)
                    {
                        MessageBox.Show("Impossível estabelecer conexão:" + Erro);
                    }
                }
            }
            return status;
        }//login_ckeck fim
    }
}
