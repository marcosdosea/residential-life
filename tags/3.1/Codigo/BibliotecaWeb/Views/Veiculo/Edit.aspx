<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.VeiculoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.editar %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.veiculos %></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%: Models.App_GlobalResources.Mensagem.editarVeiculo %></legend>

        
        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdVeiculo)%>
            <%: Html.ValidationMessageFor(model => model.IdVeiculo) %>
        </div>

        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdPessoa)%>
            <%: Html.ValidationMessageFor(model => model.IdPessoa) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.placa %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Placa) %>
            <%: Html.ValidationMessageFor(model => model.Placa) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.modelo %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Modelo) %>
            <%: Html.ValidationMessageFor(model => model.Modelo) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.cor %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Cor) %>
            <%: Html.ValidationMessageFor(model => model.Cor) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.tipoVeiculo %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("IdTipoVeiculo") %>
            <%: Html.ValidationMessageFor(model => model.IdTipoVeiculo) %>
        </div>

        <p>
            <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.editar %>" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index") %>
</div>

</asp:Content>
