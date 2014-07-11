<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.PlanoDeContaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
     <%: Models.App_GlobalResources.Mensagem.planoDeConta %> 
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2> <%: Models.App_GlobalResources.Mensagem.planoDeConta%></h2>

<p>
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.novo, "Create") %>
</p>
<table id="table">
    <tr>
        <th>
            <%: Models.App_GlobalResources.Mensagem.descricao %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.opcoes %>
        </th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Descricao) %>
        </td>
        <td>
            <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.editar , "Edit", new {  id = item.IdPlanoDeConta }) %> |
            <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.detalhes, "Details", new {  id = item.IdPlanoDeConta  }) %> |
            <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.apagar, "Delete", new {  id = item.IdPlanoDeConta }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
