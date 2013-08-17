<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.PessoaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.apagarPessoa %></h2>

<h3><%: Models.App_GlobalResources.Mensagem.confirmacaoPessoa %></h3>
<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.apagar %></legend>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apagar %></div>
    <div class="display-field">
        <%: Html.LabelFor(model => model.IdPes) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apagar %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apagar %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CPF) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apagar %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.RG) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apagar %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Sexo) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apagar %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Email) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apagar %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Login) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apagar %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Senha) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apagar %> Fixo</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TelefoneFixo) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apagar %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TelefoneCelular) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apagar %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Rua) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apagar %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Numero) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apagar %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Complemento) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apagar %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Bairro) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apagar %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CEP) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apagar %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Cidade) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.apagar %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Estado) %>
    </div>

</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value=<%: Models.App_GlobalResources.Mensagem.apagar %> /> |
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index") %>
    </p>
<% } %>

</asp:Content>
