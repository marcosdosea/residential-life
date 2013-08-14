<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.CondominioModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Create</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>CondominioModel</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.idCondominio) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.idCondominio) %>
            <%: Html.ValidationMessageFor(model => model.idCondominio) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.nome) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.nome) %>
            <%: Html.ValidationMessageFor(model => model.nome) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.rua) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.rua) %>
            <%: Html.ValidationMessageFor(model => model.rua) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.numero) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.numero) %>
            <%: Html.ValidationMessageFor(model => model.numero) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.bairro) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.bairro) %>
            <%: Html.ValidationMessageFor(model => model.bairro) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.complemento) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.complemento) %>
            <%: Html.ValidationMessageFor(model => model.complemento) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.cep) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.cep) %>
            <%: Html.ValidationMessageFor(model => model.cep) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.cidade) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.cidade) %>
            <%: Html.ValidationMessageFor(model => model.cidade) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.estado) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.estado) %>
            <%: Html.ValidationMessageFor(model => model.estado) %>
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>
