<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.BlocoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Details</h2>

<fieldset>
    <legend>BlocoModel</legend>

    <div class="display-label">IdBloco</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdBloco) %>
    </div>

    <div class="display-label">idCondominio</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdCondominio) %>
    </div>

    <div class="display-label">nome</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label">quantAndares</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.QuantidadeAndares) %>
    </div>

    <div class="display-label">quantMoradias</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.QuantidadeMoradias) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink("Edit", "Edit", new { id=Model.IdBloco  }) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>
