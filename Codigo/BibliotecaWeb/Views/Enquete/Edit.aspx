<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.EnqueteModel>" %>
<%@ Import Namespace="Model.Helpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.editarEnquete %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <%: Models.App_GlobalResources.Mensagem.editarEnquete%></h2>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>
            <%: Models.App_GlobalResources.Mensagem.enquete %></legend>
        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdEnquete) %>
        </div>
        <div class="editor-field">
            <%: Html.HiddenFor(model => model.IdPessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.HiddenFor(model => model.DataInicio) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Titulo)%>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Titulo)%>
            <%: Html.ValidationMessageFor(model => model.Titulo)%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Descricao)%>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Descricao)%>
            <%: Html.ValidationMessageFor(model => model.Descricao)%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.DataFim)%>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.DataFim, new { @class = "date", @type = "date" })%>
            <%: Html.ValidationMessageFor(model => model.DataFim)%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.StatusEnquete) %>
        </div>
        <div class="editor-field">
            <%: Html.EnumDropDownListFor(model => model.StatusEnquete, Model.StatusEnquete)%>
            <%: Html.ValidationMessageFor(model => model.StatusEnquete) %>
        </div>
    </fieldset>
    <div>
     <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.salvar %>" />
    </div>
    <% } %>
    <div>
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
    </div>
</asp:Content>
