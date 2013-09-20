<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.PostagemModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%:Models.App_GlobalResources.Mensagem.detalhes%> </h2>

<fieldset>
    <legend><%:Models.App_GlobalResources.Mensagem.detalhes%> </legend>

    <div class="display-label">IdPostagem</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdPostagem) %>
    </div>

    <div class="display-label">IdPessoa</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdPessoa) %>
    </div>

    <div class="display-label">titulo</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.titulo) %>
    </div>

    <div class="display-label">descricao</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.descricao) %>
    </div>

    <div class="display-label">dataPublAutomatica</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.dataPublAutomatica) %>
    </div>

    <div class="display-label">dataExclusaoAutomatica</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.dataExclusaoAutomatica) %>
    </div>
</fieldset>
<p>
   <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new {  id=Model.IdPostagem  })%> |
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
</p>

</asp:Content>
