<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.EnqueteModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.editarEnquete %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.editarEnquete %></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%: Models.App_GlobalResources.Mensagem.enquete %></legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.IdEnquete) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.IdEnquete) %>
            <%: Html.ValidationMessageFor(model => model.IdEnquete) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.IdPessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("IdPessoa") %>
            <%: Html.ValidationMessageFor(model => model.IdPessoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Titulo) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Titulo) %>
            <%: Html.ValidationMessageFor(model => model.Titulo) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Descricao) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Descricao) %>
            <%: Html.ValidationMessageFor(model => model.Descricao) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.DataInicio) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DataInicio) %>
            <%: Html.ValidationMessageFor(model => model.DataInicio) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.DataFim) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DataFim) %>
            <%: Html.ValidationMessageFor(model => model.DataFim) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Status) %>
        </div>
        <p>
            <%: @Html.DropDownListFor(model => model.Status, new[]
            {
                new SelectListItem {Text = "Ativada", Value = "Ativada"},
                new SelectListItem {Text = "Desativada", Value = "Desativada"},
            }, "Selecione")%> 
        </p> 

        <p>
            <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.salvar %>" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index") %>
</div>

</asp:Content>
