<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.CondominioModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%:Models.App_GlobalResources.Mensagem.condominio%></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%:Models.App_GlobalResources.Mensagem.novoCondominio%></legend>
               
        <div class="editor-label">
            <%:  Models.App_GlobalResources.Mensagem.administradora%>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.IdAdministradora, ViewBag.IdAdministradora as SelectList)%>
            <%: Html.ValidationMessageFor(model => model.IdAdministradora) %>
        </div>

        <div class="editor-label">
            <%:  Models.App_GlobalResources.Mensagem.sindico%>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.IdSindico, ViewBag.IdSindico as SelectList)%>
            <%: Html.ValidationMessageFor(model => model.IdSindico) %>
        </div>
               
        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.nome%>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nome) %>
            <%: Html.ValidationMessageFor(model => model.Nome) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.rua%>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Rua) %>
            <%: Html.ValidationMessageFor(model => model.Rua) %>
        </div>

        <div class="editor-label">
            <%:Models.App_GlobalResources.Mensagem.numero%>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Numero) %>
            <%: Html.ValidationMessageFor(model => model.Numero) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.bairro%>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Bairro) %>
            <%: Html.ValidationMessageFor(model => model.Bairro) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.complemento%>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Complemento) %>
            <%: Html.ValidationMessageFor(model => model.Complemento) %>
        </div>

        <div class="editor-label">
            <%:Models.App_GlobalResources.Mensagem.cep%>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Cep) %>
            <%: Html.ValidationMessageFor(model => model.Cep) %>
        </div>

        <div class="editor-label">
            <%:Models.App_GlobalResources.Mensagem.cidade%>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Cidade) %>
            <%: Html.ValidationMessageFor(model => model.Cidade) %>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.estado%>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Estado) %>
            <%: Html.ValidationMessageFor(model => model.Estado) %>
        </div>

        <p>
          <input type="submit" value=<%: Models.App_GlobalResources.Mensagem.salvar %> /> 
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
</div>

</asp:Content>
