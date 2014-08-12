<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.PerfilPessoaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
     <%: Models.App_GlobalResources.Mensagem.pontuarPessoa %> 
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2> <%: Models.App_GlobalResources.Mensagem.pontuarPessoa%></h2>

<table id="table">
    <tr>
        <th style="width:450px;">
            <%: Models.App_GlobalResources.Mensagem.nomePessoa %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.perfil %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.opcoes %>
        </th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomePessoa) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Perfil) %>
        </td>
        <td>
            <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.pontuar , "Create", new {  idPessoa = item.IdPessoa }) %> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.visualizarPontuacoes, "VisualizarPontuacoes", new { idPessoa = item.IdPessoa })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
