<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Historico.aspx.cs" Inherits="BuscaCep.Historico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style>
        .form {
             margin:0 auto;
             width:600px; 
             border:solid;
             border-width:1px;
             border-radius: 10px 3px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form">
        <asp:Table ID="TabelaHistorico"  runat="server" BorderColor="#6600CC" BorderStyle="Double" BorderWidth="0px" CellPadding="5" CellSpacing="5" Width="450px">
        </asp:Table>
    </div>
</asp:Content>
