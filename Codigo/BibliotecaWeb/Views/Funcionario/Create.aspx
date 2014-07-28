<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.FuncionarioModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.funcionario %></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%: Models.App_GlobalResources.Mensagem.funcionario %></legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.NomePessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("IdPessoa") %>
            <%: Html.ValidationMessageFor(model => model.IdPessoa)%>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.NomeSetor) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("IdSetor") %>
            <%: Html.ValidationMessageFor(model => model.IdSetor)%>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Ocupacao) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Ocupacao) %>
            <%: Html.ValidationMessageFor(model => model.Ocupacao) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Frequencia) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Frequencia) %>
            <%: Html.ValidationMessageFor(model => model.Frequencia) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.HorarioPermitido) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.HorarioPermitido) %>
            <%: Html.ValidationMessageFor(model => model.HorarioPermitido) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Pontuacao) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Pontuacao) %>
            <%: Html.ValidationMessageFor(model => model.Pontuacao) %>
        </div>
        <p>
             <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.salvar %>" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
</div>

</asp:Content>
