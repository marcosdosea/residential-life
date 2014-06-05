<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.VeiculoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.detalhes %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.veiculos %></h2>

<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.detalhesVeiculo %></legend>

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
<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = Model.IdVeiculo })%> |
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.voltar, "Index") %>
</p>

</asp:Content>
