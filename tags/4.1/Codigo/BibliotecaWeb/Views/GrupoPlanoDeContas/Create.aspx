<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.GrupoPlanoDeContasModel>" %>
<%@ Import Namespace="Model.Helpers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.grupoPlanoDeConta %></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%: Models.App_GlobalResources.Mensagem.grupoPlanoDeConta %></legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Descricao) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.Descricao, new { style = "width:220px", MaxLength = 100 })%>
            <%: Html.ValidationMessageFor(model => model.Descricao) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.TipoPlanoDeConta) %>
        </div>
        <div class="editor-field">
            <%: Html.EnumDropDownListFor(model => model.TipoPlanoDeConta, Models.ListaTipoPlanoConta.Receita)%>
            <%: Html.ValidationMessageFor(model => model.TipoPlanoDeConta) %>
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
