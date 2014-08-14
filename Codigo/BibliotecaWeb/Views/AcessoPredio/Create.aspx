<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.AcessoPredioModel>" %>
<%@ Import Namespace="Model.Helpers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.acessoPredio%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.novoRegistroAcesso%></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>
    <script src="../../Scripts/chamaDatetime.js" type="text/javascript"></script> 
    <script src="../../Scripts/jquery.simple-dtpicker.js" type="text/javascript"></script>
    <link href="../../Content/themes/base/jquery.simple-dtpicker.css" rel="stylesheet"
        type="text/css" />
<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%: Models.App_GlobalResources.Mensagem.registrarAcesso %></legend>

         <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.pessoa %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.IdPessoa, ViewBag.IdPessoa as SelectList, "Selecione")%>
            <%: Html.ValidationMessageFor(model => model.IdPessoa)%>
        </div>

        <!--div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.data %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.Data, new { @Class = "dateTime", @Type = "dateTime", @Value = ViewBag.HoraAtual })%>
            <%: Html.ValidationMessageFor(model => model.Data) %>
        </div-->

        <div class="editor-label">
            <%: Html.LabelFor(model => model.TipoAcesso) %>
        </div>
        <div class="editor-field">
            <%: Html.EnumDropDownListFor(model => model.TipoAcesso, Models.Models.ListaTipoAcesso.Entrada)%>
            <%: Html.ValidationMessageFor(model => model.TipoAcesso) %>
        </div>
        <br />
        <p>
            <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.salvar %>" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.voltar, "Index") %>
</div>

<input type="hidden" value="<%: Session["_AlertBox"] %>" id="alertBox" />
    <script type="text/javascript">
        var msg = document.getElementById('alertBox').value;
        if (msg == "1") {
            alert("Esta Pessoa não está alocada em uma moradia.");
        } else if (msg == "2") {
            alert("Identificador de morador não encontrado no sistema!");
        }
    </script>

</asp:Content>
