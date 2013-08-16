<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.PessoaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Pessoas</h2>

<p>
    <%: Html.ActionLink("Cadastrar Pessoa", "Create") %>
</p>
<table>
    <tr>
        <th>
            Código
        </th>
        <th>
            Nome
        </th>
        <th>
            CPF
        </th>
        <th>
            Telefone Fixo
        </th>
        <th>
            Telefone Celular
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdPes) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Nome) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.CPF) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.TelefoneFixo) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.TelefoneCelular) %>
        </td>
        <td>
            <%: Html.ActionLink("Editar", "Edit", new {  id=item.IdPes  }) %> |
            <%: Html.ActionLink("Detalhes", "Details", new { id = item.IdPes })%> |
            <%: Html.ActionLink("Apagar", "Delete", new { id = item.IdPes })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
