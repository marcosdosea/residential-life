<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.FuncionarioModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.apagarFuncionario %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.apagarFuncionario%></h2>

<h3><%: Models.App_GlobalResources.Mensagem.confirmacaoFuncionario %></h3>
<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.apagar %></legend>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.nomePessoa %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomePessoa) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.nomeSetor %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomeSetor) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.ocupacao %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Ocupacao) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.frequencia %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Frequencia) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.horarioPermitido %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.HorarioPermitido) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.pontuacao %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Pontuacao) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.apagar %>" /> |
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index") %>
    </p>
<% } %>

</asp:Content>
