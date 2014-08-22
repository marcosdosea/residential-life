<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.OcorrenciaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%:Models.App_GlobalResources.Mensagem.detalhes%> </h2>

<fieldset>
    <legend><%:Models.App_GlobalResources.Mensagem.detalhes%> </legend>

    <%: Html.HiddenFor(model => model.IdOcorrencia) %>
    <%: Html.HiddenFor(model => model.IdPessoa) %>
    
    <div class="display-label">Pessoa</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomePessoa) %>
    </div>  

    <div class="display-label">Titulo</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Titulo) %>
    </div>

    <div class="display-label">Descricao</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Descricao) %>
    </div>

    <div class="display-label">Data</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Data) %>
    </div>

    <div class="display-label">Tipo</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TipoOcorrencia) %>
    </div>

    <div class="display-label">Status</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.StatusOcorrencia) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new {  id=Model.IdOcorrencia  })%> |
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
</p>

</asp:Content>
