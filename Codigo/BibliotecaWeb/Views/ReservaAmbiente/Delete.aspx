<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.ReservaAmbienteModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.apagarPessoa %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.apagarReservaAmbiente %></h2>

<h3><%: Models.App_GlobalResources.Mensagem.confirmacaoApagarReserva %></h3>
<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.reservaAmbiente %></legend>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.id %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdRes) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.idArea %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdArea) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.idPessoa %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdPes) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.dataInicio %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DataInicio) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.dataFim %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DataFim) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.statusPagamento %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.StatusPagamento) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value=<%: Models.App_GlobalResources.Mensagem.cancelar %> /> |
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
    </p>
<% } %>

</asp:Content>
