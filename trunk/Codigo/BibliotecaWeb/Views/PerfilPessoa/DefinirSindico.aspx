<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.PessoaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.pessoas %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.pessoas %></h2>

<table id="table">
    <tr>
        <th>
            <%: Models.App_GlobalResources.Mensagem.nome %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.cpf %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.telefoneFixo %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.telefoneCelular %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.statusPerfil %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Nome) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.CPF) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.TelefoneFixo) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.TelefoneCelular) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.StatusPerfil) %>
        </td>
        <td>
            <% if (item.StatusPerfil == true)
               { %>
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.ativar, "Edit", new { idPessoa = item.IdPessoa })%> 
            <% }
               else
               { %>
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.desativar, "Details", new { idPessoa = item.IdPessoa })%>
            <% } %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
