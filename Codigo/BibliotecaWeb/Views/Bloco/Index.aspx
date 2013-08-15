<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.BlocoModel>>" %>

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
            idBloco
        </th>
        <th>
            idCondominio
        </th>
        <th>
            nome
        </th>
        <th>
            quantAndares
        </th>
        <th>
            quantMoradias
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.idBloco) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.idCondominio) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.nome) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.quantAndares) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.quantMoradias) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new { id=item.idBloco }) %> |
            <%: Html.ActionLink("Details", "Details", new { id=item.idBloco  }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { id=item.idBloco  }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
