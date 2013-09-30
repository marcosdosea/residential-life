<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.MovimentacaoFinanceiraModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.detalhesMovimentacaoFinanceira %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.detalhes %></h2>

<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.movimentacaoFinanceira %></legend>

    <div class="display-field">
        <%: Html.HiddenFor(model => model.IdMovimentacaoFinanceira) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.idAdministradora %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdAdministradora) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.administradora %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomeAdministradora) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.valorPagamento %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Valor) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.data %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Data) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.competencia %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Competencia) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.descricao %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Descricao) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.statusMovimentacaoFinanceira %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.StatusMovimentacaoFinanceira) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.planoDeConta %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PlanoDeConta) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = Model.IdMovimentacaoFinanceira })%> |
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
</p>

</asp:Content>
