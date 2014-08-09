<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.PlanoDeContaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   <%: Models.App_GlobalResources.Mensagem.detalhesPlanoDeConta %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.detalhesPlanoDeConta%></h2>

<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.planoDeConta %></legend>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.descricao %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Descricao) %>
    </div>
    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.grupoPlanoDeContas %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.DescricaoGrupoPlanoContas) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.editar, "Edit", new {  id = Model.IdPlanoDeConta}) %> |
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.voltar, "Index") %>
</p>

</asp:Content>
