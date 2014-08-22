<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.ComentarioModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.apagarComentario%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <%: Models.App_GlobalResources.Mensagem.apagarComentario%></h2>
    <h3>
        <%: Models.App_GlobalResources.Mensagem.perguntaConfirmacao %></h3>
    <fieldset>
        <legend>
            <%: Models.App_GlobalResources.Mensagem.apagar %></legend>
        <div class="display-label">
            <%:Models.App_GlobalResources.Mensagem.nomePessoa%></div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.NomePessoa) %>
        </div>
        <div class="display-label">
            <%:Models.App_GlobalResources.Mensagem.tituloPostagem%></div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Titulo) %>
        </div>
        <div class="display-label">
            <%:Models.App_GlobalResources.Mensagem.comentario%></div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Comentario) %>
        </div>
        <div class="display-label">
            <%:Models.App_GlobalResources.Mensagem.data%></div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Data) %>
        </div>
        <div class="display-label">
            <%:Models.App_GlobalResources.Mensagem.status%></div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Status) %>
        </div>
    </fieldset>
    <% using (Html.BeginForm())
       { %>
    <p>
        <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.apagar %>" />
        |
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index", "Comentario", new { idPostagem = Model.IdPostagem },
            new { @style = "font-size:small;" })%>
    </p>
    <% } %>
</asp:Content>
