<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.MovimentacaoFinanceiraModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.editarMovimentacaoFinanceira %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.editar %></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%: Models.App_GlobalResources.Mensagem.editarMovimentacaoFinanceira %></legend>

        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdMovimentacaoFinanceira) %>
            <%: Html.ValidationMessageFor(model => model.IdMovimentacaoFinanceira) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.idAdministradora %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.IdAdministradora) %>
            <%: Html.ValidationMessageFor(model => model.IdAdministradora) %>
        </div>

        <div class="editor-label">
           <%: Models.App_GlobalResources.Mensagem.valorPagamento %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Valor) %>
            <%: Html.ValidationMessageFor(model => model.Valor) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.data %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Data) %>
            <%: Html.ValidationMessageFor(model => model.Data) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.competencia %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Competencia) %>
            <%: Html.ValidationMessageFor(model => model.Competencia) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.descricao %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Descricao) %>
            <%: Html.ValidationMessageFor(model => model.Descricao) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.statusMovimentacaoFinanceira %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("IdStatusMovimentacaoFinanceira") %>
            <%: Html.ValidationMessageFor(model => model.IdStatusMovimentacaoFinanceira) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.planoDeConta %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("IdPlanoDeConta") %>
            <%: Html.ValidationMessageFor(model => model.IdPlanoDeConta) %>
        </div>

        <p>
            <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.salvar %>" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
</div>

</asp:Content>
