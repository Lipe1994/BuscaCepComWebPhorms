using DTO;
using Repositories;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Core
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            CepService cepService = new CepService();
            EnderecoFormatado enderecoFormatado = new EnderecoFormatado();
            EnderecoRepository enderecoRepository = new EnderecoRepository();
            

            var endereco = cepService.buscarEndereco(txtCep.Text);
            if (!string.IsNullOrEmpty(endereco.cep))
            {
                enderecoFormatado.cep = endereco.cep;
                enderecoFormatado.endereco = $"Rua: {endereco.logradouro},\r\nBairro: {endereco.bairro},\r\nEstado: {endereco.uf},\r\nCep: {endereco.cep}";
            }
            txtEndereco.Text = enderecoFormatado.endereco;

            enderecoRepository.AddEndereco(enderecoFormatado);
        }
    }
}