<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<Models.AtendimentoModel>" %>
<%@ Import Namespace="Model.Helpers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.editar %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.editar %></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>tb_atendimento</legend>

        <%: Html.HiddenFor(model => model.IdAtendimento) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.NomePessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("IdPessoa", "Selecione")%>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Titulo) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Titulo) %>
            <%: Html.ValidationMessageFor(model => model.Titulo) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Descricao) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Descricao) %>
            <%: Html.ValidationMessageFor(model => model.Descricao) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.StatusAtendimento) %>
        </div>
        <div class="editor-field">
            <%: Html.EnumDropDownListFor(model => model.StatusAtendimento, Models.AtendimentoModel.ListaStatusAtendimento.EmAnalise)%>
            <%: Html.ValidationMessageFor(model => model.StatusAtendimento) %>
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>
