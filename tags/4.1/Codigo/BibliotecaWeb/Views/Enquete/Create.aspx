<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.EnqueteModel>" %>
<%@ Import Namespace="Model.Helpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.enquete %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <%: Models.App_GlobalResources.Mensagem.enquete %></h2>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>
            <%: Models.App_GlobalResources.Mensagem.enquete %></legend>
        
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
            <%: Html.EnumDropDownListFor(model => model.StatusEnquete, Models.EnqueteModel.ListaStatusEnquente.EmVotacao)%>
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
