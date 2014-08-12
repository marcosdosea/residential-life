<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<Models.PessoaMoradiaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.definirProprietario%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.definirProprietario%></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%: Models.App_GlobalResources.Mensagem.definirProprietario %></legend>
        <%: Html.HiddenFor(model => model.IdMoradia) %>
        <%: Html.HiddenFor(model => model.IdPerfil) %>
        <%: Html.HiddenFor(model => model.Ativo) %>
        <div class="editor-label">
            <%: Html.Label(Models.App_GlobalResources.Mensagem.nomePessoa)%>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("IdPessoa", "Selecione")%>
            <%: Html.ValidationMessageFor(model => model.IdPessoa) %>
        </div>
        <br />
        <p>
            <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.salvar %>" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
</div>

</asp:Content>
