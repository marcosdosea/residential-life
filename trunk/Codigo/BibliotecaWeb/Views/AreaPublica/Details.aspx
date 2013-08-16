<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.AreaPublicaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Detalhes</h2>

<fieldset>
    <legend>Detalhes Área Pública</legend>

    <div class="display-label">IdCondominio</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdCondominio) %>
    </div>

    

    <div class="display-label">Nome</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label">Local</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Local) %>
    </div>

    <div class="display-label">estado</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Estado) %>
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
<p>
    <%: Html.ActionLink("Editar", "Edit", new {  id=Model.IdAreaPublica }) %> |
    <%: Html.ActionLink("Voltar", "Index") %>
</p>

</asp:Content>
