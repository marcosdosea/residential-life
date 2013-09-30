<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.MoradiaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.editar %></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%: Models.App_GlobalResources.Mensagem.moradia %></legend>

        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdMoradia) %>
            <%: Html.ValidationMessageFor(model => model.IdMoradia) %>
        </div>

        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdBloco)%>
            <%: Html.ValidationMessageFor(model => model.IdBloco) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.proprietario %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.IdPessoa, ViewBag.IdPessoa as SelectList)%>
            <%: Html.ValidationMessageFor(model => model.IdPessoa) %>
        </div>

        <div class="editor-field">
            <%: Html.HiddenFor(model => model.Predio)%>
            <%: Html.ValidationMessageFor(model => model.Predio) %>
        </div>

        <div class="editor-field">
            <%: Html.HiddenFor(model => model.Andar)%>
            <%: Html.ValidationMessageFor(model => model.Andar) %>
        </div>


        <div class="editor-field">
            <%: Html.HiddenFor(model => model.Numero)%>
            <%: Html.ValidationMessageFor(model => model.Numero) %>
        </div>

        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdTipoMoradia)%>
            <%: Html.ValidationMessageFor(model => model.IdTipoMoradia) %>
        </div>

        <div class="editor-field">
            <%: Html.HiddenFor(model => model.TipoMoradia)%>
            <%: Html.ValidationMessageFor(model => model.TipoMoradia) %>
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
