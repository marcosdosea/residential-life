<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.VeiculoModel>" %>

<%@ Import Namespace="Model.Helpers" %>
<%@ Import Namespace="Model" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.novo %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <%: Models.App_GlobalResources.Mensagem.veiculos %></h2>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"
        type="text/javascript"></script>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>
            <%: Models.App_GlobalResources.Mensagem.veiculo %></legend>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.NomePessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("IdPergunta", "Selecione") %>
            <%: Html.ValidationMessageFor(model => model.IdPessoa, string.Empty, new { @class = "styleValidation" })%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Moradia) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("IdPergunta", "Selecione") %>
            <%: Html.ValidationMessageFor(model => model.IdMoradia, string.Empty, new { @class = "styleValidation" })%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.TipoVeiculo) %>
        </div>
        <div class="editor-field">
            <%: Html.EnumDropDownListFor(model => model.TipoVeiculo, Models.ListaTipoVeiculo.Carro) %>
        </div>
        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.placa %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Placa) %>
            <%: Html.ValidationMessageFor(model => model.Placa) %>
        </div>
        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.modelo %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Modelo) %>
            <%: Html.ValidationMessageFor(model => model.Modelo) %>
        </div>
        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.cor %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Cor) %>
            <%: Html.ValidationMessageFor(model => model.Cor) %>
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
