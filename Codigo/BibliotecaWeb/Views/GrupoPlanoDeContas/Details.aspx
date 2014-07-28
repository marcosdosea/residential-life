<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.GrupoPlanoDeContasModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   <%: Models.App_GlobalResources.Mensagem.detalhesGrupoPlanoDeContas %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.detalhesGrupoPlanoDeContas%></h2>

<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.grupoPlanoDeConta %></legend>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.descricaoPlanoDeConta %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DescricaoPlanoDeConta) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.tipoPlanoDeConta %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TipoPlanoDeConta) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.descricao %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Descricao) %>
    </div>

</fieldset>
<p>
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.editar, "Edit", new {  id = Model.IdTipoPlanoDeConta}) %> |
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.voltar, "Index") %>
</p>

</asp:Content>
