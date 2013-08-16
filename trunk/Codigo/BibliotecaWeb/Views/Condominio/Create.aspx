<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.CondominioModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Condominios
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.condominio %></h2>

<script src="<%: Url.Content("~/Scripts/jquery.valIDate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.valIDate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%: Models.App_GlobalResources.Mensagem.condominio %></legend>

           <div class="editor-label">
            <%: Html.LabelFor(model => model.IDSindico) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.IDSindico) %>
            <%: Html.ValidationMessageFor(model => model.IDSindico) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Nome) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nome) %>
            <%: Html.ValidationMessageFor(model => model.Nome) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Rua) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Rua) %>
            <%: Html.ValidationMessageFor(model => model.Rua) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Numero) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Numero) %>
            <%: Html.ValidationMessageFor(model => model.Numero) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Bairro) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Bairro) %>
            <%: Html.ValidationMessageFor(model => model.Bairro) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Complemento) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Complemento) %>
            <%: Html.ValidationMessageFor(model => model.Complemento) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Cep) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Cep) %>
            <%: Html.ValidationMessageFor(model => model.Cep) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Cidade) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Cidade) %>
            <%: Html.ValidationMessageFor(model => model.Cidade) %>
        </div>

        
          <div class="editor-label">
            <%: Html.LabelFor(model => model.Estado) %>
        </div>
        <p>
            <%: @Html.DropDownListFor(model => model.Estado, new[]
            {
                new SelectListItem {Text = "Sergipe", Value = "SE"},
                new SelectListItem {Text = "Bahia", Value = "BA"},
                new SelectListItem {Text = "Alagoas", Value = "AL"},

            }, "Selecione")%> 
        </p>    
 

        <p>
            <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.salvar %>" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
</div>

</asp:Content>
