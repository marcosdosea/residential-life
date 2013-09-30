<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.PlanoDeContaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.apagarPlanoDeConta %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.apagarPlanoDeConta %></h2>

<h3><%: Models.App_GlobalResources.Mensagem.confirmacaoApagarPlanoDeConta %></h3>
<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.planoDeConta %></legend>

    <div class="display-field">
        <%: Html.HiddenFor(model => model.IdPlanoDeConta) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.descricao %></div>
    <div class="display-field">
        <%: Html.TextAreaFor(model => model.Descricao) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.tipoDePlanoDeConta %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TipoPlanoDeConta) %>
    </div>

</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.apagar %>" /> |
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
    </p>
<% } %>

</asp:Content>
