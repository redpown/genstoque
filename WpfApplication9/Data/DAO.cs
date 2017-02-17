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
    public class DAO
    {
       public int status = 1;
       public  MySqlConnection conexao; //MySQL
       // MySqlDataAdapter bdAdapter;
       public MySqlDataReader reader;
       public DataSet bdDataSet; //MySQL

       public DAO() {
            //Definição do dataset
            bdDataSet = new DataSet();
            //Define string de conexão
            conexao = new MySqlConnection("server=localhost;database=uhair;uid=root;pwd=");
            //Abre conecção
            try
            {
                conexao.Open();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Impossível estabelecer conexão:" + Erro);
            }
        }//construtor fim


        /*public int login_check(Usuarios_Model user)
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
                    conexao.Open();
                    //Se estiver aberta insere os dados na BD
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
                    reader.Close();
                    conexao.Close();

                }
                catch (Exception Erro)
                {
                    reader.Close();
                    conexao.Close();
                    MessageBox.Show("Impossível estabelecer conexão:" + Erro);
                }
                
            }
           
            return status;
        }//login_ckeck fim*/

     /*   public int insert_new_user(Usuarios_Model user)
        {
            //Abre conecção
            using (MySqlCommand comando = new MySqlCommand(
                "INSERT INTO usuarios (usuario, senha, chave)" +
                "VALUES " +
                "(" +
                "@Email," +
                "@Senha,"+
                "@Chave);", conexao))
            {
                try
                {
                   // conexao.Open();
                    if (conexao.State == ConnectionState.Open)
                    {
                        //Se estiver aberta insere os dados na BD
                        // comando.Parameters.AddWithValue("@Nome", nome.Text);// para sql usar .Parameters.Add
                        comando.Parameters.AddWithValue("@Email", user.login);
                        comando.Parameters.AddWithValue("@Senha", user.senha);
                        comando.Parameters.AddWithValue("@Chave", user.chave);
                        comando.BeginExecuteNonQuery();
                    }
                    status = 0;
//                    conexao.Close();
                }
                catch (Exception Erro)
                {
                    status = 1;
 //                   conexao.Close();
                    MessageBox.Show("Impossível estabelecer conexão:" + Erro);
                }
              
            }
            return status;
        }//insert_new_user*/

        public int update_user(Usuarios_Model user)
        {
            //Abre conecção
            using (MySqlCommand comando = new MySqlCommand(
                    "UPDATE usuarios "+
                    "SET senha = @Senha " +
                    "WHERE usuario = @Email "+
                    "and chave = @Chave; ", conexao))
            {
                try
                {
                    conexao.Open();
                    if (conexao.State == ConnectionState.Open)
                    {
                        //Se estiver aberta insere os dados na BD
                        // comando.Parameters.AddWithValue("@Nome", nome.Text);// para sql usar .Parameters.Add
                        comando.Parameters.AddWithValue("@Email", user.login);
                        comando.Parameters.AddWithValue("@Senha", user.senha);
                        comando.Parameters.AddWithValue("@Chave", user.chave);
                        comando.BeginExecuteNonQuery();
                    }
                    status = 0;
                    conexao.Close();
                }
                catch (Exception Erro)
                {
                    status = 1;
                    conexao.Close();
                    MessageBox.Show("Impossível estabelecer conexão:" + Erro);
                }

            }
            return status;
        }//update_user

        public int delete_user(Usuarios_Model user)
        {
            //Abre conecção
            using (MySqlCommand comando = new MySqlCommand(
                   "DELETE FROM usuarios "+
                   "WHERE chave = @Chave AND  usuario = @Email; ", conexao))
            {
                try
                {
                    conexao.Open();
                    if (conexao.State == ConnectionState.Open)
                    {
                        //Se estiver aberta insere os dados na BD
                        // comando.Parameters.AddWithValue("@Nome", nome.Text);// para sql usar .Parameters.Add
                        comando.Parameters.AddWithValue("@Email", user.login);
                        comando.Parameters.AddWithValue("@Chave", user.chave);
                        comando.BeginExecuteNonQuery();
                    }
                    status = 0;
                    conexao.Close();
                }
                catch (Exception Erro)
                {
                    status = 1;
                    conexao.Close();
                    MessageBox.Show("Impossível estabelecer conexão:" + Erro);
                }

            }
            return this.status;
        }//delete_user
//--------------------------------------------------------------------------//
    /*    public int insert_new_Empresa(Clientes_Model cliente)
        {
            //Abre conecção
            using (MySqlCommand comando = new MySqlCommand("INSERT INTO clientes ( cod , nome ,  endereco ,  bairro ,  cidade , estado , cep ,  tel ,  cel ,  senha ,  email , tipo ) VALUES ( @cod , @nome ,  @endereco ,  @bairro ,  @cidade , @uf , @cep  ,  @tel ,  @cel ,  @senha ,  @email , @tipo );", conexao))
            {
                try
                {
                    if (conexao.State == ConnectionState.Open)
                    {
                        // "INSERT INTO clientes ( cod ,  nome ,  endereco ,  bairro ,  cidade ,  estado ,  cep ,  tel ,  cel ,  senha ,  email ,  tipo ) VALUES ('@cod', '@nome', '@endereco', '@bairro', '@cidade', '@estado',  '@cep' , '@tel', '@cel', '@senha', '@email', '@tipo');", conexao))
                        //Se estiver aberta insere os dados na BD
                         // comando.Parameters.AddWithValue("@Nome", nome.Text);
                          comando.Parameters.AddWithValue("@cod", cliente.cod);
                          comando.Parameters.AddWithValue("@nome", cliente.nome);
                          comando.Parameters.AddWithValue("@endereco", cliente.endereco);
                          comando.Parameters.AddWithValue("@bairro", cliente.bairro);
                          comando.Parameters.AddWithValue("@cidade", cliente.cidade);
                          comando.Parameters.AddWithValue("@uf", cliente.uf);
                          comando.Parameters.AddWithValue("@cep", cliente.cep);
                          comando.Parameters.AddWithValue("@tel", cliente.tel);
                          comando.Parameters.AddWithValue("@cel", cliente.cel);
                          comando.Parameters.AddWithValue("@senha", cliente.senha);
                          comando.Parameters.AddWithValue("@email", cliente.email);
                          comando.Parameters.AddWithValue("@tipo", cliente.tipo_check());
                        
                        comando.BeginExecuteNonQuery();
                    }
                    status = 0;
                    
                }
                catch (Exception Erro)
                {
                    this.status = 1;
                    MessageBox.Show("Impossível estabelecer conexão: " + Erro);
                }

            }
            return status;
        }//insert_new_Empresa*/

        public int update_Empresa(Clientes_Model cliente)
        {
            //Abre conecção
            using (MySqlCommand comando = new MySqlCommand(
                    "UPDATE clientes "+
                "SET nome = @nome " +
                "endereco = @endereco" +
                "bairro   = @bairro" +
                "cidade   = @cidade" +
                "estado   = @estado" +
                "cep      = @cep" +
                "tel      = @tel" +
                "cel      = @cel" +
                "senha    = @senha" +
                "email    = @email" +
                "tipo     = @tipo "+
                "WHERE cod = @cod;", conexao))
            {
                try
                {
                    conexao.Open();
                    if (conexao.State == ConnectionState.Open)
                    {
                        //Se estiver aberta insere os dados na BD
                        // comando.Parameters.AddWithValue("@Nome", nome.Text);// para sql usar .Parameters.Add
                        comando.Parameters.AddWithValue("@nome", cliente.nome);
                        comando.Parameters.AddWithValue("@endereco", cliente.endereco);
                        comando.Parameters.AddWithValue("@bairro", cliente.bairro);
                        comando.Parameters.AddWithValue("@cidade", cliente.cidade);
                        comando.Parameters.AddWithValue("@uf", cliente.uf);
                        comando.Parameters.AddWithValue("@cep", cliente.cep);
                        comando.Parameters.AddWithValue("@tel", cliente.tel);
                        comando.Parameters.AddWithValue("@cel", cliente.cel);
                        comando.Parameters.AddWithValue("@senha", cliente.senha);
                        comando.Parameters.AddWithValue("@email", cliente.email);
                        comando.Parameters.AddWithValue("@tipo", Convert.ToInt16(cliente.tipo_check()));
                        comando.Parameters.AddWithValue("@cod", Convert.ToInt64(cliente.cod));
                        comando.BeginExecuteNonQuery();
                    }
                    this.status = 0;
                    this.conexao.Close();
                }
                catch (Exception Erro)
                {
                    this.status = 1;
                    this.conexao.Close();
                    MessageBox.Show("Impossível estabelecer conexão:" + Erro);
                }

            }
            return this.status;
        }//update_Empresa

        public int delete_Empresa(Clientes_Model cliente)
        {
            //Abre conecção
            using (MySqlCommand comando = new MySqlCommand(
                   "DELETE FROM clientes WHERE cod = @cod;", conexao))
            {
                try
                {
                    conexao.Open();
                    if (conexao.State == ConnectionState.Open)
                    {
                        //Se estiver aberta insere os dados na BD
                        // comando.Parameters.AddWithValue("@Nome", nome.Text);// para sql usar .Parameters.Add
                        comando.Parameters.AddWithValue("@cod", Convert.ToInt64(cliente.cod));
                        comando.BeginExecuteNonQuery();
                    }
                    this.status = 0;
                    this.conexao.Close();
                }
                catch (Exception Erro)
                {
                    this.status = 1;
                    this.conexao.Close();
                    MessageBox.Show("Impossível estabelecer conexão:" + Erro);
                }

            }
            return this.status;
        }//delete_Empresa

    }//class
}//namespae
   


