using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EnderecoRepository : Connection
    {
        List<EnderecoFormatado> enderecos = new List<EnderecoFormatado>();


        public void AddEndereco(EnderecoFormatado endereco) {
            var sql = $"insert into enderecos(Cep, Endereco) values('{endereco.cep}', '{endereco.endereco}')";
            Execute(sql);
        }

        public List<EnderecoFormatado> getEnderecos()
        {
            var reader = GetComand("select Cep, Endereco from enderecos");
            

            while (reader.Read())
            {
                var endereco = new EnderecoFormatado();
                endereco.cep = reader.GetString(0);
                endereco.endereco = reader.GetString(1);
                Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));

                enderecos.Add(endereco);          
            }
            Close();
            return enderecos;
        }
    }
}
