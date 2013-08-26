<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.EnqueteModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.detalhesEnquete %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.detalhesEnquete %></h2>

<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.enquete %></legend>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.criador %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomeCriador) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.titulo %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Titulo) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.descricao %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Descricao) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.dataInicioEnquete %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DataInicio) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.dataFimEnquete %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DataFim) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.status %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.StatusEnquete) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = Model.IdEnquete })%> |
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
</p>

</asp:Content>
