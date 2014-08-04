<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.ComentarioModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%:Models.App_GlobalResources.Mensagem.detalhesComentario%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <%:Models.App_GlobalResources.Mensagem.detalhesComentario%>
    </h2>
    <fieldset>
        <legend>
            <%:Models.App_GlobalResources.Mensagem.comentario%>
        </legend>
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
    <p>
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index", "Comentario", new { idPostagem = Model.IdPostagem },
            new { @style = "font-size:small;" })%>
        <% if(Model.IdPessoa.Equals(ViewBag.IdPessoaLogada)) { %>
            |<%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", "Comentario", new { id = Model.IdComentario },
                new { @style = "font-size:small;" })%>
        <% } %>
    </p>
</asp:Content>
