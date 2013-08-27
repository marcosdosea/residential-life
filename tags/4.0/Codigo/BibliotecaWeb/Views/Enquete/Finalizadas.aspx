<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.EnqueteModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.enquetes %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.enquetesFinalizadas %></h2>

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.novaEnquete, "Create") %>
</p>

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.todasEnquetes, "Index") %>
</p>

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.enquetesEmAndamento, "EmAndamento") %>
</p>
<table id="table">
    <tr>
  
        <th>
            <%: Models.App_GlobalResources.Mensagem.criador %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.titulo %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.dataInicioEnquete%>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.dataFimEnquete %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.status %>
        </th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
   
        <td>
            <%: Html.DisplayFor(modelItem => item.NomeCriador) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Titulo) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.DataInicio) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.DataFim) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.StatusEnquete) %>
        </td>
        <td>
            <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.editar , "Edit", new {  id=item.IdEnquete }) %> |
            <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.detalhes, "Details", new {  id=item.IdEnquete  }) %> |
            <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.apagar, "Delete", new {  id=item.IdEnquete }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
