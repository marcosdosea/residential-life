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
            <%: Html.DisplayFor(modelItem => item.IdBloco) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdCondominio) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Nome) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.QuantidadeAndares) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.QuantidadeMoradias) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new { id=item.IdBloco }) %> |
            <%: Html.ActionLink("Details", "Details", new { id=item.IdBloco  }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { id=item.IdBloco  }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
