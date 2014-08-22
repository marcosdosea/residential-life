<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.RegisterModel>" %>

<asp:Content ID="registerTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Register
</asp:Content>
<asp:Content ID="registerContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Create a New Account</h2>
    <p>
        Use the form below to create a new account.
    </p>
    <p>
        Passwords are required to be a minimum of
        <%: Membership.MinRequiredPasswordLength %>
        characters in length.
    </p>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"
        type="text/javascript"></script>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true, "Account creation was unsuccessful. Please correct the errors and try again.") %>
    <div>
        <fieldset>
            <legend>Account Information</legend>
            <div class="editor-label">
                <%: Html.LabelFor(m => m.UserName) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(m => m.UserName) %>
                <%: Html.ValidationMessageFor(m => m.UserName) %>
            </div>
            <div class="editor-label">
                <%: Html.LabelFor(m => m.Email) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(m => m.Email) %>
                <%: Html.ValidationMessageFor(m => m.Email) %>
            </div>
            <div class="editor-label">
                <%: Html.LabelFor(m => m.ConfirmaEmail) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(m => m.ConfirmaEmail)%>
                <%: Html.ValidationMessageFor(m => m.ConfirmaEmail)%>
            </div>
            <div class="editor-label">
                <%: Html.LabelFor(m => m.Password) %>
            </div>
            <div class="editor-field">
                <%: Html.PasswordFor(m => m.Password) %>
                <%: Html.ValidationMessageFor(m => m.Password) %>
            </div>
            <div class="editor-label">
                <%: Html.LabelFor(m => m.ConfirmPassword) %>
            </div>
            <div class="editor-field">
                <%: Html.PasswordFor(m => m.ConfirmPassword) %>
                <%: Html.ValidationMessageFor(m => m.ConfirmPassword) %>
            </div>
            <div class="editor-label">
                <%: Models.App_GlobalResources.Mensagem.nome %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.Nome) %>
                <%: Html.ValidationMessageFor(model => model.Nome) %>
            </div>
            <div class="editor-label">
                <%: Models.App_GlobalResources.Mensagem.cpf %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.CPF) %>
                <%: Html.ValidationMessageFor(model => model.CPF) %>
            </div>
            <div class="editor-label">
                <%: Models.App_GlobalResources.Mensagem.rg %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.RG) %>
                <%: Html.ValidationMessageFor(model => model.RG) %>
            </div>
            <div class="editor-label">
                <%: Models.App_GlobalResources.Mensagem.sexo %>
            </div>
            <div class="editor-field">
                <%: Html.RadioButtonFor(model => model.Sexo, 'M') %>
                Masculino
                <br />
                <%: Html.RadioButtonFor(model => model.Sexo, 'F') %>
                Feminino
                <%: Html.ValidationMessageFor(model => model.Sexo) %>
            </div>
            <div class="editor-label">
                <%: Models.App_GlobalResources.Mensagem.telefoneFixo %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.TelefoneFixo) %>
                <%: Html.ValidationMessageFor(model => model.TelefoneFixo) %>
            </div>
            <div class="editor-label">
                <%: Models.App_GlobalResources.Mensagem.telefoneCelular %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.TelefoneCelular) %>
                <%: Html.ValidationMessageFor(model => model.TelefoneCelular) %>
            </div>
            <div class="editor-label">
                <%: Models.App_GlobalResources.Mensagem.rua %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.Rua) %>
                <%: Html.ValidationMessageFor(model => model.Rua) %>
            </div>
            <div class="editor-label">
                <%: Models.App_GlobalResources.Mensagem.numero %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.Numero) %>
                <%: Html.ValidationMessageFor(model => model.Numero) %>
            </div>
            <div class="editor-label">
                <%: Models.App_GlobalResources.Mensagem.complemento %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.Complemento) %>
                <%: Html.ValidationMessageFor(model => model.Complemento) %>
            </div>
            <div class="editor-label">
                <%: Models.App_GlobalResources.Mensagem.bairro %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.Bairro) %>
                <%: Html.ValidationMessageFor(model => model.Bairro) %>
            </div>
            <div class="editor-label">
                <%: Models.App_GlobalResources.Mensagem.cep %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.CEP) %>
                <%: Html.ValidationMessageFor(model => model.CEP) %>
            </div>
            <div class="editor-label">
                <%: Models.App_GlobalResources.Mensagem.cidade %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.Cidade) %>
                <%: Html.ValidationMessageFor(model => model.Cidade) %>
            </div>
            <div class="editor-label">
                <%: Models.App_GlobalResources.Mensagem.estado %>
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
                <input type="submit" value="Registrar" />
            </p>
        </fieldset>
    </div>
    <% } %>
</asp:Content>
