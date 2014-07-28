<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.GrupoPlanoDeContasModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.apagarGrupoPlanoDeConta %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.apagarGrupoPlanoDeConta%></h2>

<h3><%: Models.App_GlobalResources.Mensagem.confirmacaoGrupoPlanoDeConta %></h3>
<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.apagar %></legend>

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
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.apagar %>" /> |
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index") %>
    </p>
<% } %>

</asp:Content>
