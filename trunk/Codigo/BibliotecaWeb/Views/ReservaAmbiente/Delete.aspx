<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.ReservaAmbienteModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>ReservaAmbienteModel</legend>

    <div class="display-label">IdRes</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdRes) %>
    </div>

    <div class="display-label">IdArea</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdArea) %>
    </div>

    <div class="display-label">IdPes</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdPes) %>
    </div>

    <div class="display-label">DataInicio</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DataInicio) %>
    </div>

    <div class="display-label">DataFim</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DataFim) %>
    </div>

    <div class="display-label">StatusPagamento</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.StatusPagamento) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
<% } %>

</asp:Content>
