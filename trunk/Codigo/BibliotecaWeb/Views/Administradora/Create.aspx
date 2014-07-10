<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.AdministradoraModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.novaAdministradora %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.novaAdministradora %></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%: Models.App_GlobalResources.Mensagem.novaAdministradora %></legend>

      
        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.nome %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nome) %>
            <%: Html.ValidationMessageFor(model => model.Nome) %>
        </div>

        
        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.login %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Login) %>
            <%: Html.ValidationMessageFor(model => model.Login) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.senha %>
        </div>
        <div class="editor-field">
            <%: Html.PasswordFor(model => model.Senha)%>
            <%: Html.ValidationMessageFor(model => model.Senha) %>
        </div>


        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.email %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Email) %>
            <%: Html.ValidationMessageFor(model => model.Email) %>
        </div>

        <p>
            <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.salvar %>" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
</div>

</asp:Content>
