<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.MoradiaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Create</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend> <%: Models.App_GlobalResources.Mensagem.moradia %></legend>

      
        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.bloco %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.IdBloco, ViewBag.IdBloco as SelectList)%>
            <%: Html.ValidationMessageFor(model => model.IdBloco) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.proprietario %>
        </div>
        <div class="editor-field">
           <%: Html.DropDownListFor(model => model.IdPessoa, ViewBag.IdPessoa as SelectList)%>
            <%: Html.ValidationMessageFor(model => model.IdPessoa) %>
        </div>

        <div class="editor-label">
             <%: Models.App_GlobalResources.Mensagem.predio %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Predio) %>
            <%: Html.ValidationMessageFor(model => model.Predio) %>
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
             <%: Models.App_GlobalResources.Mensagem.tipoMoradia %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.IdTipoMoradia, ViewBag.IdTipoMoradia as SelectList)%>
            <%: Html.ValidationMessageFor(model => model.IdTipoMoradia) %>
        </div>
                
        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>
