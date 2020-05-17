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
            List<TableCell> cells = new List<TableCell>();
            List<TableRow> rows = new List<TableRow>();

            foreach (var endereco in enderecos)
            {
                cells.Add(new TableCell());
                cells.Add(new TableCell());


                rows.Add(new TableRow());

                var ultimaCell = cells[cells.Count - 1]; 
                var pnultimoCell = cells[cells.Count - 2];

                ultimaCell.Text = endereco.cep;
                pnultimoCell.Text = endereco.endereco;

                rows[rows.Count-1].Cells.Add(ultimaCell);
                rows[rows.Count - 1].Cells.Add(pnultimoCell);

                TabelaHistorico.Rows.Add(rows[rows.Count - 1]);
            }
        }
    }
}