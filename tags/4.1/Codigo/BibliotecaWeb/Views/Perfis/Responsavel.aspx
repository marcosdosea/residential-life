<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.PessoaMoradiaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.responsaveis%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.responsaveis%></h2>
<p>
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.novoResponsavel, "DefinirResponsavel", "Perfis") %>
</p>
<table id="table">
    <tr>
        <th>
            <%: Models.App_GlobalResources.Mensagem.nomePessoa %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.bloco %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.proprietario %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.moradia %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.ativo %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.opcoes %>
        </th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomePessoa) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Bloco) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomePessoa) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.NumeroMoradia) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Ativo) %>
        </td>
        <td>
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.remover, "RemoverResponsavel", "Perfis", new { idPessoa = item.IdPessoa, 
                idMoradia = item.IdMoradia, idPerfil = item.IdPerfil }, new { @style = "font-size:small;" })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
