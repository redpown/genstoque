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
using WpfApplication9.Data;

namespace WpfApplication9.Data
{
    public class DaoCadastroEmpresa:DAO
    {
        //--------------------------------------------------------------------------//
        public int insert_new_Empresa(Clientes_Model cliente)
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
                    status = 1;
                    MessageBox.Show("Impossível estabelecer conexão: " + Erro);
                }

            }
            return status;
        }//insert_new_Empresa
    }
}
