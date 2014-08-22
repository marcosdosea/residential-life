<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.PontuarPessoaModel>" %>
<%@ Import Namespace="Model.Helpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   <%: Models.App_GlobalResources.Mensagem.pontuarPessoa %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.pontuarPessoa%></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%: Models.App_GlobalResources.Mensagem.pontuar %></legend>
        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdPessoa) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.NomePessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.NomePessoa)%>
            <%: Html.ValidationMessageFor(model => model.NomePessoa) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Pontuacao) %>
        </div>
        <div class="editor-field">
            <%: Html.EnumDropDownListFor(model => model.Pontuacao, Models.ListaPontuacao.Zero)%>
            <%: Html.ValidationMessageFor(model => model.Pontuacao) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Comentario) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.Comentario)%>
            <%: Html.ValidationMessageFor(model => model.Comentario) %>
        </div>

        <p>
            <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.salvar %>" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index") %>
</div>

</asp:Content>
