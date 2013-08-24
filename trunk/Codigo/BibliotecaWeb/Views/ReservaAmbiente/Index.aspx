<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.ReservaAmbienteModel>>" %>

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
            IdRes
        </th>
        <th>
            IdArea
        </th>
        <th>
            IdPes
        </th>
        <th>
            DataInicio
        </th>
        <th>
            DataFim
        </th>
        <th>
            StatusPagamento
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdRes) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdArea) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdPes) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.DataInicio) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.DataFim) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.StatusPagamento) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new {  id=item.IdRes}) %> |
            <%: Html.ActionLink("Details", "Details", new { id = item.IdRes })%> |
            <%: Html.ActionLink("Delete", "Delete", new { id = item.IdRes })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
