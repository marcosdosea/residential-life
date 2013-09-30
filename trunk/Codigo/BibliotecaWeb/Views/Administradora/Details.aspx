<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.AdministradoraModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Details</h2>

<fieldset>
    <legend>AdministradoraModel</legend>

    <div class="display-label">IdAdministradora</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdAdministradora) %>
    </div>

    <div class="display-label">Nome</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label">Senha</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Senha) %>
    </div>

    <div class="display-label">Login</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Login) %>
    </div>

    <div class="display-label">Email</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Email) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink("Edit", "Edit", new { /* id=Model.PrimaryKey */ }) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>
