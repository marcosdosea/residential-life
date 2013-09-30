<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.MoradiaModel>>" %>

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
            IdMoradia
        </th>
        <th>
            IdBloco
        </th>
        <th>
            IdPessoa
        </th>
        <th>
            Predio
        </th>
        <th>
            Andar
        </th>
        <th>
            Numero
        </th>
        <th>
            IdTipoMoradia
        </th>
        <th>
            TipoMoradia
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdMoradia) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdBloco) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdPessoa) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Predio) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Andar) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Numero) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdTipoMoradia) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.TipoMoradia) %>
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
