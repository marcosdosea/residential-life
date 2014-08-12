<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.BlocoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   <%: Models.App_GlobalResources.Mensagem.detalhesBloco %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.detalhesBloco %></h2>

<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.bloco %></legend>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.id %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdBloco) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.idCondominio %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdCondominio) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.nome %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.qtdeAndares %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.QuantidadeAndares) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.qtdeMoradias %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.QuantidadeMoradias) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.editar, "Edit", new {  id=Model.IdBloco}) %> |
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.voltar, "Index") %>
</p>

</asp:Content>
