<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.CondominioModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.apargarCondominio%></h2>

<h3><%: Models.App_GlobalResources.Mensagem.perguntaConfirmacao %></h3>
<fieldset>
     <legend><%: Models.App_GlobalResources.Mensagem.condominio %></legend>

    <div class="display-label">Nome</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label">Rua</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Rua) %>
    </div>

    <div class="display-label">Numero</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Numero) %>
    </div>

    <div class="display-label">Bairro</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Bairro) %>
    </div>

    <div class="display-label">Complemento</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Complemento) %>
    </div>

    <div class="display-label">Cep</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Cep) %>
    </div>

    <div class="display-label">Cidade</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Cidade) %>
    </div>

    <div class="display-label">Estado</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Estado) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
       <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.apagar %>" /> |
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
    </p>
<% } %>

</asp:Content>
