<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<Models.tb_pontuacaopessoa>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Edit</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>tb_pontuacaopessoa</legend>

        <%: Html.HiddenFor(model => model.IdPontuacao) %>

        <%: Html.HiddenFor(model => model.IdPessoa) %>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Comentario) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Comentario) %>
            <%: Html.ValidationMessageFor(model => model.Comentario) %>
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
