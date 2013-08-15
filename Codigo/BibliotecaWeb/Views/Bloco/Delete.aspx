<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.BlocoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>BlocoModel</legend>

    <div class="display-label">idBloco</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.idBloco) %>
    </div>

    <div class="display-label">idCondominio</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.idCondominio) %>
    </div>

    <div class="display-label">nome</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.nome) %>
    </div>

    <div class="display-label">quantAndares</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.quantAndares) %>
    </div>

    <div class="display-label">quantMoradias</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.quantMoradias) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
<% } %>

</asp:Content>
