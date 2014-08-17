<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<Models.RestricaoAcessoModel>" %>

<%@ Import Namespace="Model.Helpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.novaRestricao %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <%: Models.App_GlobalResources.Mensagem.novaRestricao %></h2>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"
        type="text/javascript"></script>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>
            <%: Models.App_GlobalResources.Mensagem.restricoesAcesso %></legend>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Segunda) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Segunda) %>
            <%: Html.ValidationMessageFor(model => model.Segunda) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Terca) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Terca) %>
            <%: Html.ValidationMessageFor(model => model.Terca) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Quarta) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Quarta) %>
            <%: Html.ValidationMessageFor(model => model.Quarta) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Quinta) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Quinta) %>
            <%: Html.ValidationMessageFor(model => model.Quinta) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Sexta) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Sexta) %>
            <%: Html.ValidationMessageFor(model => model.Sexta) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Sabado) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Sabado) %>
            <%: Html.ValidationMessageFor(model => model.Sabado) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Domingo) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Domingo)%>
            <%: Html.ValidationMessageFor(model => model.Domingo) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.HoraEntrada) %>
        </div>
        <div class="editor-field">
            <%: Html.EnumDropDownListFor(model => model.HoraEntrada, Models.ListaHora.ZeroHora)%>
            <%: Html.ValidationMessageFor(model => model.HoraEntrada) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.HoraSaida) %>
        </div>
        <div class="editor-field">
            <%: Html.EnumDropDownListFor(model => model.HoraSaida, Models.ListaHora.ZeroHora)%>
            <%: Html.ValidationMessageFor(model => model.HoraSaida) %>
        </div>
        <br />
        <p>
            <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.salvar %>" />
        </p>
    </fieldset>
    <% } %>
    <div>
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Profissional", "PessoaMoradia")%>
    </div>
</asp:Content>
