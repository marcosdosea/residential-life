<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.EnqueteModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.votar %></h2>

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.novaEnquete, "Create") %>
</p>
        <table id="table">
    <tr>
       
        <th>
            <%: Models.App_GlobalResources.Mensagem.titulo %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.descricao %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.dataInicio %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.dataFim %>
        </th>

        <th>
            <%: Models.App_GlobalResources.Mensagem.criador %>
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
            <%: Html.DisplayFor(modelItem => item.NomeCriador) %>
        </td>

    </tr>
<% } %>

</table>

</asp:Content>
