<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.BlocoModel>" %>

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
        <legend>BlocoModel</legend>

      
        <div class="editor-field">
            <%: Html.HiddenFor(model => model.idBloco) %>
            <%: Html.ValidationMessageFor(model => model.idBloco) %>
        </div>

        <div class="editor-field">
            <%: Html.HiddenFor(model => model.idCondominio)%>
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
            <%: Html.LabelFor(model => model.quantAndares) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.quantAndares) %>
            <%: Html.ValidationMessageFor(model => model.quantAndares) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.quantMoradias) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.quantMoradias) %>
            <%: Html.ValidationMessageFor(model => model.quantMoradias) %>
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
