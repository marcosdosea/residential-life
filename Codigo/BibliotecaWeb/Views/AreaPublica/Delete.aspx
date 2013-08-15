<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.AreaPublicaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>AreaPublicaModel</legend>

    <div class="display-label">idAreaPublica</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.idAreaPublica) %>
    </div>

    <div class="display-label">idCondominio</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.idCondominio) %>
    </div>

    <div class="display-label">estado</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.estado) %>
    </div>

    <div class="display-label">nome</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.nome) %>
    </div>

    <div class="display-label">local</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.local) %>
    </div>

    <div class="display-label">tamanho</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.tamanho) %>
    </div>

    <div class="display-label">valorPagamento</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.valorPagamento) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
<% } %>

</asp:Content>
