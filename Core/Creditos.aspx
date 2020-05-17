<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Creditos.aspx.cs" Inherits="Core.paginas.Creditos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style>
        table {
             margin:0 auto;
             width:600px; 
             border:solid;
             border-width:1px;
             border-radius: 10px 3px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <table  border="1">
           <tr>
               <th>Descrição</th>
               <th>Referência</th>
           </tr>
           <tr>
               <td>Autor</td>
               <td>Filipe Ferreira</td>
           </tr>
           <tr>
               <td>WS de terceiros</td>
               <td>ViaCep(viacep.com.br)</td>
           </tr>
           <tr>
               <td>Nuget</td>
               <td>NewtonSoft</td>
           </tr>    
       </table>
</asp:Content>
