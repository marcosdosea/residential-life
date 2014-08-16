<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.PessoaMoradiaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.visitantes%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.visitantes%></h2>
<p>
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.novoVisitante, "DefinirVisitante", "PessoaMoradia") %>
</p>
<table id="table">
    <tr>
        <th>
            <%: Models.App_GlobalResources.Mensagem.visitante %>
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
            <%: Html.DisplayFor(modelItem => item.NumeroMoradia) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Ativo) %>
        </td>
        <td>
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.remover, "RemoverVisitante", "PessoaMoradia", new { idPessoa = item.IdPessoa, 
                idMoradia = item.IdMoradia, idPerfil = item.IdPerfil }, new { @style = "font-size:small;" })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.restricoesAcesso, "RestricoesVisitante", "PessoaMoradia",
                new { idMoradia = item.IdMoradia, idPessoa = item.IdPessoa }, new { @style = "font-size:small;" })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
