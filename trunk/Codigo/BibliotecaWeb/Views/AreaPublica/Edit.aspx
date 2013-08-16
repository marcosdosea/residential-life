<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.AreaPublicaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Editar</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Editar Área Pública</legend>

        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdAreaPublica) %>
            <%: Html.ValidationMessageFor(model => model.IdAreaPublica) %>
        </div>


        <div class="editor-label">
            <%: Html.LabelFor(model => model.IdCondominio) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.IdCondominio) %>
            <%: Html.ValidationMessageFor(model => model.IdCondominio) %>
        </div>

       

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Nome) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nome) %>
            <%: Html.ValidationMessageFor(model => model.Nome) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Local) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Local) %>
            <%: Html.ValidationMessageFor(model => model.Local) %>
        </div>

          <div class="editor-label">
            <%: Html.LabelFor(model => model.Estado) %>
        </div>
        <div class="editor-field">
            Disponivel <%: Html.RadioButtonFor(model => model.Estado, "Disponivel", true)%>
            Indisponivel <%: Html.RadioButtonFor(model => model.Estado, "Indisponivel", false)%>
            <%: Html.ValidationMessageFor(model => model.Estado)%>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Tamanho) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Tamanho) %>
            <%: Html.ValidationMessageFor(model => model.Tamanho) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ValorPagamento) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ValorPagamento) %>
            <%: Html.ValidationMessageFor(model => model.ValorPagamento) %>
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Voltar", "Index") %>
</div>

</asp:Content>
