<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.PlanoDeContaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.planosDeConta %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.planosDeConta %></h2>

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.novoPlanoDeConta, "Create")%>
</p>
<table id="table">
    <tr>
        <th>
            <%: Models.App_GlobalResources.Mensagem.tipoDePlanoDeConta %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.descricao %>
        </th>
        
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        
            <%: Html.HiddenFor(modelItem => item.IdPlanoDeConta) %>
        
        <td>
            <%: Html.DisplayFor(modelItem => item.TipoPlanoDeConta) %>
        </td>
        <td>
            <%: Html.TextAreaFor(modelItem => item.Descricao) %>
        </td>
        <td>
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = item.IdPlanoDeConta })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.detalhes, "Details", new { id = item.IdPlanoDeConta })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.apagar, "Delete", new { id = item.IdPlanoDeConta })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
