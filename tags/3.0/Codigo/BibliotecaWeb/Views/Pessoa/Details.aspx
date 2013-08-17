<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.PessoaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.detalhesPessoa %></h2>

<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.detalhes %></legend>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.id %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdPes) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.nome %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.cpf %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CPF) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.rg %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.RG) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.sexo %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Sexo) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.email %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Email) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.login %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Login) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.senha %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Senha) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.telefoneFixo %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TelefoneFixo) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.telefoneCelular %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TelefoneCelular) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.rua %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Rua) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.numero %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Numero) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.complemento %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Complemento) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.bairro %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Bairro) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.cep %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CEP) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.cidade %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Cidade) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.estado %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Estado) %>
    </div>

</fieldset>
<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id=Model.IdPes }) %> |
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index") %>
</p>

</asp:Content>
