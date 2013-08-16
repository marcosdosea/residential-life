<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.AreaPublicaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Deletar</h2>

<h3>Você está seguro que quer fazer isso?</h3>
<fieldset>
    <legend>Deletar Área Publica </legend>

    <div class="display-label">IdAreaPublica</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdAreaPublica) %>
    </div>

    <div class="display-label">IdCondominio</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdCondominio) %>
    </div>

    <div class="display-label">estado</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Estado) %>
    </div>

    <div class="display-label">nome</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label">local</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Local) %>
    </div>

    <div class="display-label">tamanho</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Tamanho) %>
    </div>

    <div class="display-label">valorPagamento</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.ValorPagamento) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Voltar ", "Index") %>
    </p>
<% } %>

</asp:Content>
