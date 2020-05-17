using DTO;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace Services
{
    public class CepService
    {
        public Endereco buscarEndereco(string cep)
        {
            if (string.IsNullOrEmpty(cep) || !(cep.Length == 8))
                return new Endereco();

            HttpClient cliente = new HttpClient();
            try
            {
                var uri = $"https://viacep.com.br/ws/{cep}/json/unicode/";
                var retorno = cliente.GetStringAsync(uri);

                var endereco = JsonConvert.DeserializeObject<Endereco>(retorno.Result);
                return endereco;
            }
            catch
            {
                throw new Exception("Erro ao acessar viacep.com.br/ws");
            }
        }
    }
}

