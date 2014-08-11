<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.AcessoVeiculoModel>>" %>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.registrarAcessoVeiculo %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.registrarAcesso %></h2>

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.registrar, "Create") %> &nbsp <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.gerarRelatorio, "ReportAcessoVeiculo")%>
</p>
<table id="table">
    <tr>
        <th>
            <%: Models.App_GlobalResources.Mensagem.placa %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.data %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.tipo %>
        </th>
        <th><%: Models.App_GlobalResources.Mensagem.opcoes %></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.PlacaVeiculo) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Data) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.TipoAcesso) %>
        </td>
        <td>
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = item.IdAcessoVeiculo })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.detalhes, "Details", new { id = item.IdAcessoVeiculo })%> |
            <%: Html.ActionLink("Delete", "Delete", new { id=item.IdAcessoVeiculo }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
