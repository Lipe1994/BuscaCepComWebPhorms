using DTO;
using Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuscaCep
{
    public partial class Historico : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            EnderecoRepository enderecoRepository = new EnderecoRepository();
            List<EnderecoFormatado> enderecos = enderecoRepository.getEnderecos();

            MountHeader(TabelaHistorico);
            Mountbody(enderecos);
        }

        public void MountHeader(Table table)
        {   var row = new TableRow();
            TableHeaderCell tbHeaderIndex = new TableHeaderCell();
            TableHeaderCell tbHeaderDescricao = new TableHeaderCell();

            tbHeaderIndex.Text = "CEP";
            tbHeaderDescricao.Text = "Endereço";

            row.Cells.Add(tbHeaderIndex);
            row.Cells.Add(tbHeaderDescricao);
            table.Rows.Add(row);
        }

        public void Mountbody(List<EnderecoFormatado> enderecos)
        {

            foreach (var endereco in enderecos)
            {
                var tableCellCep = new TableCell();
                var tableCellEndereco = new TableCell();

                var row = new TableRow();
                tableCellCep.Text = endereco.cep;
                tableCellEndereco.Text = endereco.endereco;

                row.Cells.Add(tableCellCep);
                row.Cells.Add(tableCellEndereco);

                TabelaHistorico.Rows.Add(row);
            }
        }
    }
}