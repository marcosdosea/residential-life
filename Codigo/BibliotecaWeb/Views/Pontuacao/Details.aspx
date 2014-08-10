<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.PontuacaoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.detalhesPontuacao %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.detalhesPontuacao %></h2>

<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.pontuacao %></legend>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.pontuacao %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Pontuacao) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = Model.IdPontuacao })%> |
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
</p>

</asp:Content>
