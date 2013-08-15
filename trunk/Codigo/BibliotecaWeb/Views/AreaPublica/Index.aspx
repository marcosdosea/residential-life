<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.AreaPublicaModel>>" %>

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
            idAreaPublica
        </th>
        <th>
            idCondominio
        </th>
        <th>
            Estado
        </th>
        <th>
            nome
        </th>
        <th>
            local
        </th>
        <th>
            tamanho
        </th>
        <th>
            valorPagamento
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.idAreaPublica) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.idCondominio) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Estado) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.nome) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.local) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.tamanho) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.valorPagamento) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
            <%: Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
