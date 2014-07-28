<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.FuncionarioModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
   <%: Models.App_GlobalResources.Mensagem.detalhesFuncionario %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.detalhesFuncionario%></h2>

<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.funcionario %></legend>

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
<p>
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.editar, "Edit", new {  id = Model.IdFuncionario}) %> |
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.voltar, "Index") %>
</p>

</asp:Content>
