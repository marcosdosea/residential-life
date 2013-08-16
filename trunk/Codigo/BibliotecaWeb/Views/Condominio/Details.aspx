<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.CondominioModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Details</h2>

<fieldset>
    <legend>CondominioModel</legend>

  

    <div class="display-label">IDSindico</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IDSindico) %>
    </div>

    <div class="display-label">Nome</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label">Rua</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Rua) %>
    </div>

    <div class="display-label">Numero</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Numero) %>
    </div>

    <div class="display-label">Bairro</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Bairro) %>
    </div>

    <div class="display-label">Complemento</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Complemento) %>
    </div>

    <div class="display-label">Cep</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Cep) %>
    </div>

    <div class="display-label">Cidade</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Cidade) %>
    </div>

    <div class="display-label">Estado</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Estado) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink("Edit", "Edit", new {  id=Model.IDCondominio}) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>
