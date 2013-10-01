<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.MoradiaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.apagar %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.apagar%></h2>

<h3><%: Models.App_GlobalResources.Mensagem.confirmacaoApagarMoradia%></h3>
<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.moradia%></legend>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.bloco%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomeBloco) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.proprietario%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomePessoa) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.predio%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Predio) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.andar%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Andar) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.numero%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Numero) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.tipoMoradia%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TipoMoradia) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.apagar %>" /> |
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
    </p>
<% } %>

</asp:Content>
