<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.ReservaAmbienteModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Details</h2>

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
<p>
    <%: Html.ActionLink("Edit", "Edit", new { id = item.IdRes })%> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>
