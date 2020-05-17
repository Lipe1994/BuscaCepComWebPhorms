<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Core.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .form {
             margin:0 auto;
             width:600px; 
             border:solid;
             border-width:1px;
             border-radius: 10px 3px;
        }
        .header-form {
            padding: 20px;
            margin:0 auto;
        }
        .body-form {
            padding: 20px;  
            margin:0 auto;
            overflow:hidden;
        }
        .text-endereco{
            width:450px; 
            height:80px;
            margin:0 auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="form">
            <div class="header-form">
                <asp:Label  runat="server" Text="Label">Digite um Cep:</asp:Label>
                <asp:TextBox ID="txtCep" runat="server"></asp:TextBox><asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" OnClick="btnPesquisar_Click" />
            </div>
            <div class="body-form">
                <asp:Label  runat="server" Text="Label">Endereço: </asp:Label><br />
                <asp:TextBox Style="overflow:hidden; resize:none;" BorderWidth="0" class="text-endereco" ID="txtEndereco" runat="server" TextMode="MultiLine" ReadOnly="True" EnableTheming="True" ViewStateMode="Enabled" Wrap="False"></asp:TextBox>
            </div>
        </div>
</asp:Content>
