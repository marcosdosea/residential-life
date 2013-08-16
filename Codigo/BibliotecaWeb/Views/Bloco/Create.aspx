<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.BlocoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Criar Bloco
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Criar Bloco</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>BlocoModel</legend>

      
        <div class="editor-label">
            <%: Html.LabelFor(model => model.IdCondominio) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.IdCondominio) %>
            <%: Html.ValidationMessageFor(model => model.IdCondominio) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Nome) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nome) %>
            <%: Html.ValidationMessageFor(model => model.Nome) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.QuantidadeAndares) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.QuantidadeAndares) %>
            <%: Html.ValidationMessageFor(model => model.QuantidadeAndares) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.QuantidadeMoradias) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.QuantidadeMoradias) %>
            <%: Html.ValidationMessageFor(model => model.QuantidadeMoradias) %>
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
