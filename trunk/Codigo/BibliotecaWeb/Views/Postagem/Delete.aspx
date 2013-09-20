<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.PostagemModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.apagarPostagem%></h2>

<h3><%: Models.App_GlobalResources.Mensagem.perguntaConfirmacao %></h3>
<fieldset>
     <legend><%: Models.App_GlobalResources.Mensagem.apagar %></legend>

    <div class="display-label">IdPessoa</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IdPessoa) %>
    </div>

    <div class="display-label">titulo</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.titulo) %>
    </div>

    <div class="display-label">descricao</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.descricao) %>
    </div>

    <div class="display-label">dataPublAutomatica</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.dataPublAutomatica) %>
    </div>

    <div class="display-label">dataExclusaoAutomatica</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.dataExclusaoAutomatica) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
         <input type="submit" value=<%: Models.App_GlobalResources.Mensagem.apagar %> /> |
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
    </p>
<% } %>

</asp:Content>
