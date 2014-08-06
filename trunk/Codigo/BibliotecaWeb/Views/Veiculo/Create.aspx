<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.VeiculoModel>" %>

<%@ Import Namespace="Model.Helpers" %>
<%@ Import Namespace="Model" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.novo %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <%: Models.App_GlobalResources.Mensagem.veiculos %></h2>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"
        type="text/javascript"></script>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>
            <%: Models.App_GlobalResources.Mensagem.veiculo %></legend>

        <% using (Html.BeginForm("Create", "Veiculo", FormMethod.Post, null))
         { %>
        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.condominio%>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.IdCondominio, ViewBag.IdCondominio as SelectList, "Selecione", new { onchange = "this.form.submit();" })%>
            <%: Html.ValidationMessageFor(model => model.IdCondominio)%>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.bloco%>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.IdBloco, ViewBag.IdBloco as SelectList, "Selecione", new { onchange = "this.form.submit();" })%>
            <%: Html.ValidationMessageFor(model => model.IdBloco)%>
        </div>

        <div class="editor-label">
            <%: Html.Label(Models.App_GlobalResources.Mensagem.moradia)%>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.IdMoradia, ViewBag.IdMoradia as SelectList, "Selecione", new { onchange = "this.form.submit();" })%>
            <%: Html.ValidationMessageFor(model => model.IdMoradia) %>
        </div>
        
        <% } %>


        <div class="editor-label">
            <%: Html.LabelFor(model => model.TipoVeiculo) %>
        </div>
        <div class="editor-field">
            <%: Html.EnumDropDownListFor(model => model.TipoVeiculo, Models.ListaTipoVeiculo.Carro) %>
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
        <p>
            <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.salvar %>" />
        </p>
    </fieldset>
    <% } %>
    <div>
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
    </div>
</asp:Content>
