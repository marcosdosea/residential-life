<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<Models.tb_pessoamoradia>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.detalhes %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.detalhes %></h2>

<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.alocar_pessoa_moradia %></legend>

    <div class="display-label">Tipo</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Tipo) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink("Edit", "Edit", new { /* id=Model.PrimaryKey */ }) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>
