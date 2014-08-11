<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<Models.Models.AcessoVeiculoModel>" %>
<%@ Import Namespace="Model.Helpers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.registrarAcessoVeiculo %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.registrar %></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%: Models.App_GlobalResources.Mensagem.acessoVeiculo %></legend>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.veiculo %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.IdVeiculo, ViewBag.IdVeiculo as SelectList, "Selecione")%>
            <%: Html.ValidationMessageFor(model => model.IdVeiculo)%>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Data) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.Data, new { @class = "date", @type = "date" })%>
            <%: Html.ValidationMessageFor(model => model.Data) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.TipoAcesso) %>
        </div>
        <div class="editor-field">
            <%: Html.EnumDropDownListFor(model => model.TipoAcesso, Models.Models.ListaTipoAcesso.Entrada)%>
            <%: Html.ValidationMessageFor(model => model.TipoAcesso) %>
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
