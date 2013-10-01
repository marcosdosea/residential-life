<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.AcessoPredioModel>>" %>

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
            IdPessoa
        </th>
        <th>
            DataEntrada
        </th>
        <th>
            DataSaida
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
       
        <td>
            <%: Html.DisplayFor(modelItem => item.IdPessoa) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.DataEntrada) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.DataSaida) %>
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
