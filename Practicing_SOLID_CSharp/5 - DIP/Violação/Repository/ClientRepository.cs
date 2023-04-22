using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practicing_SOLID_CSharp._5___DIP.Violação.Models;

namespace Practicing_SOLID_CSharp._5___DIP.Violação.Repository
{
    public class ClientRepository
    {
        public void AddClient(Client client)
        {
            try
            {
                using (var cn = new SqlConnection())
                {
                    var cmd = new SqlCommand();

                    cn.ConnectionString = "MinhaConnectionString";
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))";

                    cmd.Parameters.AddWithValue("nome", client.Nome);
                    cmd.Parameters.AddWithValue("email", client.Email);
                    cmd.Parameters.AddWithValue("cpf", client.CPF);
                    cmd.Parameters.AddWithValue("dataCad", client.DataCadastro);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }   
    }
}
