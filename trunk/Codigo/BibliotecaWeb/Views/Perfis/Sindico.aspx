<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.PessoaMoradiaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.sindicos %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.sindicos%></h2>
<p>
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.novoSindico, "DefinirResponsavel", "Perfis") %>
</p>
<table id="table">
    <tr>
        <th>
            <%: Models.App_GlobalResources.Mensagem.nome %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.perfil %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.condominio %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.ativo %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.opcoes %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomePessoa) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Perfil) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Condominio) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Ativo) %>
        </td>
        <td>
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.remover, "RemoverSindico", "Perfis", new { idPessoa = item.IdPessoa, 
                idMoradia = item.IdMoradia, idPerfil = item.IdPerfil }, new { @style = "font-size:small;" })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
