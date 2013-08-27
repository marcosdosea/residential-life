<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.ReservaAmbienteModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.novaReservaAmbiente %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.novaReservaAmbiente %></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%: Models.App_GlobalResources.Mensagem.reservaAmbiente %></legend>

        
        <div class="editor-label">
            <%: Html.LabelFor(model => model.IdAreaPublica) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("IdAreaPublica")%>
            <%: Html.ValidationMessageFor(model => model.IdAreaPublica) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.IdPesssoa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.IdPesssoa) %>
            <%: Html.ValidationMessageFor(model => model.IdPesssoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.DataInicio) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DataInicio) %>
            <%: Html.ValidationMessageFor(model => model.DataInicio) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.DataFim) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DataFim) %>
            <%: Html.ValidationMessageFor(model => model.DataFim) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.IdStatusPagamento) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("IdStatusPagamento")%>
            <%: Html.ValidationMessageFor(model => model.IdStatusPagamento) %>
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
