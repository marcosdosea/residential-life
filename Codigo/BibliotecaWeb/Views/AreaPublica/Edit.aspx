<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.AreaPublicaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Edit</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>AreaPublicaModel</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.idAreaPublica) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.idAreaPublica) %>
            <%: Html.ValidationMessageFor(model => model.idAreaPublica) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.idCondominio) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.idCondominio) %>
            <%: Html.ValidationMessageFor(model => model.idCondominio) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.estado) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.estado) %>
            <%: Html.ValidationMessageFor(model => model.estado) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.nome) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.nome) %>
            <%: Html.ValidationMessageFor(model => model.nome) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.local) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.local) %>
            <%: Html.ValidationMessageFor(model => model.local) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.tamanho) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.tamanho) %>
            <%: Html.ValidationMessageFor(model => model.tamanho) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.valorPagamento) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.valorPagamento) %>
            <%: Html.ValidationMessageFor(model => model.valorPagamento) %>
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>
