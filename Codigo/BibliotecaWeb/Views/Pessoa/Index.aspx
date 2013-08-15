<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.PessoaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
<table>
    <tr>
        <th>
            Nome
        </th>
        <th>
            CPF
        </th>
        <th>
            TelefoneFixo
        </th>
        <th>
            TelefoneCelular
        </th>
        <th>
            Tipo
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
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
            <%: Html.DisplayFor(modelItem => item.Tipo) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new {  id=item.IdPes  }) %> |
            <%: Html.ActionLink("Details", "Details", new { id = item.IdPes })%> |
            <%: Html.ActionLink("Delete", "Delete", new { id = item.IdPes })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
