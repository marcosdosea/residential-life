<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.AcessoPredioModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
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
        <legend><%: Models.App_GlobalResources.Mensagem.acessoPredio %></legend>

        <%: ViewBag.Mensagem %>

         <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.codigoPessoa %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.IdPessoa) %>
            <%: Html.ValidationMessageFor(model => model.IdPessoa) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.dataEntrada %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.DataEntrada, new { @Class = "dateTime", @Type = "dateTime", @Value = ViewBag.HoraAtual })%>
            <%: Html.ValidationMessageFor(model => model.DataEntrada) %>
        </div>

        <div class="editor-label">
           <%: Models.App_GlobalResources.Mensagem.dataSaida %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DataSaida) %>
            <%: Html.ValidationMessageFor(model => model.DataSaida) %>
        </div>

        <p>
            <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.salvar %>" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.voltar, "Index") %>
</div>

</asp:Content>
