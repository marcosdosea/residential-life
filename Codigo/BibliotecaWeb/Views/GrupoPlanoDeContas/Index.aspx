<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.GrupoPlanoDeContasModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
     <%: Models.App_GlobalResources.Mensagem.grupoPlanoDeContas %> 
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2> <%: Models.App_GlobalResources.Mensagem.grupoPlanoDeContas%></h2>

<p>
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.novo, "Create") %>
</p>
<table id="table">
    <tr>
        <th style="width:400px;">
            <%: Models.App_GlobalResources.Mensagem.descricaoPlanoDeConta %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.tipoPlanoDeConta %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.opcoes %>
        </th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Descricao)%>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.TipoPlanoDeConta)%>
        </td>
        <td>
            <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.editar , "Edit", new {  id = item.IdGrupoPlanoDeConta }) %> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.detalhes, "Details", new { id = item.IdGrupoPlanoDeConta })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.apagar, "Delete", new { id = item.IdGrupoPlanoDeConta })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
