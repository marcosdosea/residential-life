<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.PessoaMoradiaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.selecionarPerfil %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.selecionarPerfil%></h2>

<table id="table">
    <tr>
        <th>
            <%: Models.App_GlobalResources.Mensagem.condominio %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.bloco %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.moradia %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.perfil %>
        </th>
        <th><%: Models.App_GlobalResources.Mensagem.opcoes %></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td style="width:200px;">
            <%: Html.DisplayFor(modelItem => item.Condominio) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Bloco) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.NumeroMoradia) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Perfil) %>
        </td>
        <td>
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.selecionar, "Selecionar", "Home", new { idPessoa = item.IdPessoa, 
                idPerfil = item.IdPerfil, idMoradia = item.IdMoradia }, new { @style = "font-size:small;"})%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
