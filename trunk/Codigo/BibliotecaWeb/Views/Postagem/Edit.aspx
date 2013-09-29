<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.PostagemModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%:Models.App_GlobalResources.Mensagem.editar%></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
       <legend><%:Models.App_GlobalResources.Mensagem.editar%></legend>

        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdPessoa) %>
            <%: Html.ValidationMessageFor(model => model.IdPessoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.titulo) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.titulo) %>
            <%: Html.ValidationMessageFor(model => model.titulo) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.descricao) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.descricao) %>
            <%: Html.ValidationMessageFor(model => model.descricao) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.dataPublAutomatica) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.dataPublAutomatica) %>
            <%: Html.ValidationMessageFor(model => model.dataPublAutomatica) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.dataExclusaoAutomatica) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.dataExclusaoAutomatica) %>
            <%: Html.ValidationMessageFor(model => model.dataExclusaoAutomatica) %>
        </div>

        <p>
               <input type="submit" value=<%: Models.App_GlobalResources.Mensagem.salvar %> />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
</div>

</asp:Content>
