<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.MoradiaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.moradia %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.moradia %></h2>

<p>
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.novaMoradia, "Create") %>
</p>
<table id="table">
    <tr>
        <th>
            <%: Models.App_GlobalResources.Mensagem.numero %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.andar %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.bloco %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.condominio %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.tipoMoradia%>
        </th>
        <th><%: Models.App_GlobalResources.Mensagem.opcoes%></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Numero) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Andar) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomeBloco) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Condominio) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.TipoMoradia) %>
        </td>
        <td>
            <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.editarProprietario, "Edit", new { id=item.IdMoradia }) %> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.apagar, "Delete", new { id = item.IdMoradia })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
