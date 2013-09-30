<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.MovimentacaoFinanceiraModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.movimentacoesFinanceiras %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.movimentacaoFinanceira %></h2>

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.novaMovimentacaoFinanceira, "Create") %>
</p>
<table id="table">
    <tr>
        <th>
            <%: Models.App_GlobalResources.Mensagem.idAdministradora %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.valorPagamento %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.data %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.competencia %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.descricao %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.statusMovimentacaoFinanceira %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.planoDeConta %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
            <%: Html.HiddenFor(modelItem => item.IdMovimentacaoFinanceira) %>
        <td>
            <%: Html.DisplayFor(modelItem => item.IdAdministradora) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Valor) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Data) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Competencia) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Descricao) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.StatusMovimentacaoFinanceira) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.PlanoDeConta) %>
        </td>
        <td>
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = item.IdMovimentacaoFinanceira })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.detalhes, "Details", new { id = item.IdMovimentacaoFinanceira })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.apagar, "Delete", new { id = item.IdMovimentacaoFinanceira })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
