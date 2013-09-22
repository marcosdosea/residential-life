<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.VeiculoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.apagar %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.veiculos %></h2>

<h3><%: Models.App_GlobalResources.Mensagem.confirmacaoApagarVeiculo %></h3>
<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.veiculo %></legend>

    <div class="display-field">
        <%: Html.HiddenFor(model => model.IdVeiculo) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.placa %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Placa) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.modelo %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Modelo) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.cor %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Cor) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.tipoVeiculo %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Tipo) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.apagar %>" /> |
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index") %>
    </p>
<% } %>

</asp:Content>
