﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.EnqueteModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Votar
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Votar</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
        <table id="table">
    <tr>
       
        <th>
            Titulo
        </th>
        <th>
            Descricao
        </th>
        <th>
            DataInicio
        </th>
        <th>
            DataFim
        </th>
        <th>
            IdStatusEnquete
        </th>
        <th>
            StatusEnquete
        </th>
        <th>
            NomeCriador
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
      
        <td>
            <%: Html.ActionLink(item.Titulo, "VotarEnquete", new { id = item.IdEnquete })%>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Descricao) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.DataInicio) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.DataFim) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdStatusEnquete) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.StatusEnquete) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomeCriador) %>
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
