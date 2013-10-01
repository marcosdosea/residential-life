<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.AcessoPredioModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Create</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>AcessoPredioModel</legend>

         <div class="editor-label">
            <%: Html.LabelFor(model => model.IdPessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.IdPessoa) %>
            <%: Html.ValidationMessageFor(model => model.IdPessoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.DataEntrada) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DataEntrada) %>
            <%: Html.ValidationMessageFor(model => model.DataEntrada) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.DataSaida) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DataSaida) %>
            <%: Html.ValidationMessageFor(model => model.DataSaida) %>
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>
