<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.MoradiaModel>" %>
<%@ Import Namespace="Model.Helpers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.moradia %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.moradia %></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend> <%: Models.App_GlobalResources.Mensagem.moradia %></legend>

      <% using (Html.BeginForm("Create", "Moradia", FormMethod.Post, null))
         { %>
        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.condominio%>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("IdCondominio", null, "Selecione", new { onchange = "this.form.submit();" })%>
            <%: Html.ValidationMessageFor(model => model.IdCondominio)%>
        </div>
        <% } %>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.bloco%>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.IdBloco, ViewBag.IdBloco as SelectList, "Selecione")%>
            <%: Html.ValidationMessageFor(model => model.IdBloco)%>
        </div>

        <div class="editor-label">
             <%: Models.App_GlobalResources.Mensagem.andar %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Andar) %>
            <%: Html.ValidationMessageFor(model => model.Andar) %>
        </div>

        <div class="editor-label">
             <%: Models.App_GlobalResources.Mensagem.numero %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Numero) %>
            <%: Html.ValidationMessageFor(model => model.Numero) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.TipoMoradia) %>
        </div>
        <div class="editor-field">
            <%: Html.EnumDropDownListFor(model => model.TipoMoradia, Models.MoradiaModel.ListaTipoMoradia.Padrao)%>
            <%: Html.ValidationMessageFor(model => model.TipoMoradia) %>
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
