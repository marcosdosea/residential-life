<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<Models.tb_atendimento>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Details</h2>

<fieldset>
    <legend>tb_atendimento</legend>

    <div class="display-label">tb_pessoa</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.tb_pessoa.CPF) %>
    </div>

    <div class="display-label">Titulo</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Titulo) %>
    </div>

    <div class="display-label">Descricao</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Descricao) %>
    </div>

    <div class="display-label">StatusAtendimento</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.StatusAtendimento) %>
    </div>
</fieldset>
<p>

    <%: Html.ActionLink("Edit", "Edit", new { id=Model.IdAtendimento }) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>
