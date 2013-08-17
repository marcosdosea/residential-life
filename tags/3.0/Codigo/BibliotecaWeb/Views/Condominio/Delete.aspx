<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.CondominioModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.apagarCondominio %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.apagarCondominio %></h2>

<h3><%: Models.App_GlobalResources.Mensagem.confirmacaoCondominio %></h3>
<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.apagar %></legend>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.idCondominio %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IDCondominio) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.idSindico %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IDSindico) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.nome %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.rua %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Rua) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.numero %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Numero) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.bairro %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Bairro) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.complemento %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Complemento) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.cep %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Cep) %>
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
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value=<%: Models.App_GlobalResources.Mensagem.apagar %> /> |
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index") %>
    </p>
<% } %>

</asp:Content>
