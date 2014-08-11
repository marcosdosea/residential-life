<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.PontuarPessoaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
     <%: Models.App_GlobalResources.Mensagem.pontuacoes %> 
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2> <%: Models.App_GlobalResources.Mensagem.pontuacoes%></h2>
<div><b><%: Models.App_GlobalResources.Mensagem.nomePessoa %>:</b> <%: ViewBag.NomePessoa %></div>
<table id="table">
    <tr>
        <th>
            <%: Models.App_GlobalResources.Mensagem.nomePessoa %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.comentario %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.pontuacao %>
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
            <%: Html.DisplayFor(modelItem => item.Comentario) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Pontuacao) %>
        </td>
        <td>
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = item.IdPontuacaoPessoa })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.detalhes, "Details", new { id = item.IdPontuacaoPessoa })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.apagar, "Delete", new { id = item.IdPontuacaoPessoa })%>
        </td>
    </tr>
<% } %>

</table>
<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index") %>
</div>
</asp:Content>
