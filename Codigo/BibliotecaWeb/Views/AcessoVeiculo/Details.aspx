<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<Models.AcessoVeiculoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.registrarAcessoVeiculo %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.detalhes %></h2>

<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.detalhes %></legend>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.data %></div>
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
<p>

    <%: Html.ActionLink("Edit", "Edit", new { id=Model.IdAcessoVeiculo }) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>
