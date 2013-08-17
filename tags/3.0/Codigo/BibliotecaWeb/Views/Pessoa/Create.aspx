<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.PessoaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.novaPessoa %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.novaPessoa %></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%: Models.App_GlobalResources.Mensagem.novo %></legend>

        
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Nome) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nome) %>
            <%: Html.ValidationMessageFor(model => model.Nome) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CPF) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CPF) %>
            <%: Html.ValidationMessageFor(model => model.CPF) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.RG) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.RG) %>
            <%: Html.ValidationMessageFor(model => model.RG) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Sexo) %>
        </div>
        <div class="editor-field">
            <%: Html.RadioButtonFor(model => model.Sexo, 'M') %> Masculino <br /> 
            <%: Html.RadioButtonFor(model => model.Sexo, 'F') %> Feminino
            <%: Html.ValidationMessageFor(model => model.Sexo) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Email) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Email) %>
            <%: Html.ValidationMessageFor(model => model.Email) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Login) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Login) %>
            <%: Html.ValidationMessageFor(model => model.Login) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Senha) %>
        </div>
        <div class="editor-field">
            <%: Html.PasswordFor(model => model.Senha) %>
            <%: Html.ValidationMessageFor(model => model.Senha) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.TelefoneFixo) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.TelefoneFixo) %>
            <%: Html.ValidationMessageFor(model => model.TelefoneFixo) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.TelefoneCelular) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.TelefoneCelular) %>
            <%: Html.ValidationMessageFor(model => model.TelefoneCelular) %>
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
            <%: Html.LabelFor(model => model.Complemento) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Complemento) %>
            <%: Html.ValidationMessageFor(model => model.Complemento) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Bairro) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Bairro) %>
            <%: Html.ValidationMessageFor(model => model.Bairro) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CEP) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CEP) %>
            <%: Html.ValidationMessageFor(model => model.CEP) %>
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
            <input type="submit" value=<%: Models.App_GlobalResources.Mensagem.salvar %> />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index") %>
</div>

</asp:Content>
