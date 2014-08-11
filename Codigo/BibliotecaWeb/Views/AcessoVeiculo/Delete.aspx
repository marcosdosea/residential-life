<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<Models.Models.AcessoVeiculoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.excluir %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.excluir %></h2>
<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.detalhes %></legend>

    <div class="display-label">DataHora</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Data) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.placa %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PlacaVeiculo) %>
    </div>

    <div class="display-label">Tipo Acesso</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TipoAcesso) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index") %>
    </p>
<% } %>

</asp:Content>
