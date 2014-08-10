<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.PontuacaoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.apagarPontuacao %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <%: Models.App_GlobalResources.Mensagem.apagarPontuacao %></h2>
    <h3>
        <%: Models.App_GlobalResources.Mensagem.confirmacaoApagarPontuacao %></h3>
    <fieldset>
        <legend>
            <%: Models.App_GlobalResources.Mensagem.apagar %></legend>
        <div class="display-label">
            <%: Models.App_GlobalResources.Mensagem.pontuacao %></div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Pontuacao) %>
        </div>
    </fieldset>
    <% using (Html.BeginForm())
       { %>
    <p>
        <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.apagar %>" />
        |
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index") %>
    </p>
    <% } %>
</asp:Content>
