<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.PostagemModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%:Models.App_GlobalResources.Mensagem.detalhesPostagem%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <%:Models.App_GlobalResources.Mensagem.detalhesPostagem%>
    </h2>
    <fieldset>
        <legend>
            <%:Models.App_GlobalResources.Mensagem.postagem%>
        </legend>
        <div class="display-label">
            <%:Models.App_GlobalResources.Mensagem.titulo%></div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Titulo) %>
        </div>
        <div class="display-label">
            <%:Models.App_GlobalResources.Mensagem.descricao%></div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Descricao) %>
        </div>
        <div class="display-label">
            <%:Models.App_GlobalResources.Mensagem.dataPublicacao%></div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.DataPublicacao) %>
        </div>
        <div class="display-label">
            <%:Models.App_GlobalResources.Mensagem.dataExclusao%></div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.DataExclusao) %>
        </div>
    </fieldset>
    <p>
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
        <% if(Model.IdPessoa.Equals(ViewBag.IdPessoa)) { %>
            |<%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", "Postagem", new { id = Model.IdPostagem })%>
        <% } %>
    </p>
</asp:Content>
