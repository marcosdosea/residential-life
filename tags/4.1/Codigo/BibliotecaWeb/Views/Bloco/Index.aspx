<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.BlocoModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
     <%: Models.App_GlobalResources.Mensagem.blocos %> 
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2> <%: Models.App_GlobalResources.Mensagem.blocos %></h2>

<p>
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.novo, "Create") %>
</p>
<table id="table">
    <tr>
        <th style="width:400px;">
            <%: Models.App_GlobalResources.Mensagem.nome %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.condominio %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.qtdeAndares %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.qtdeMoradias %>
        </th>
        <th><%: Models.App_GlobalResources.Mensagem.opcoes %></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Nome)%>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomeCondominio)%>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.QuantidadeAndares) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.QuantidadeMoradias) %>
        </td>
        <td>
            <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.editar , "Edit", new {  id=item.IdBloco }) %> |
            <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.detalhes, "Details", new {  id=item.IdBloco  }) %> |
            <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.apagar, "Delete", new {  id=item.IdBloco }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
