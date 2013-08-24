<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.ReservaAmbienteModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.detalhesReservaAmbiente %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.detalhesReservaAmbiente %></h2>

<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.reservaAmbiente %></legend>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.id %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdRes) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.areaPublica %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomeAreaPublica) %>
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
<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = Model.IdRes })%> |
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
</p>

</asp:Content>
