<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.ComentarioModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%:Models.App_GlobalResources.Mensagem.editarComentario%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <%:Models.App_GlobalResources.Mensagem.editarComentario%></h2>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"
        type="text/javascript"></script>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>
            <%:Models.App_GlobalResources.Mensagem.editar%></legend>
        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdPessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdPostagem) %>
        </div>
        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdComentario) %>
        </div>
        <div class="editor-field">
            <%: Html.HiddenFor(model => model.Data) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Comentario) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Comentario) %>
            <%: Html.ValidationMessageFor(model => model.Comentario) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Status) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Status) %>
            <%: Html.ValidationMessageFor(model => model.Status) %>
        </div>
        <p>
            <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.salvar %>" />
        </p>
    </fieldset>
    <% } %>
    <div>
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index", "Comentario", new { idPostagem = Model.IdPostagem }, 
            new { @style = "font-size:small;" })%>
    </div>
</asp:Content>
