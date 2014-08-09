<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.AlocarPessoaMoradiaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.alocar_pessoa_moradia %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.alocar_pessoa_moradia %></h2>

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.alocar, "Create")%> &nbsp <%: Html.ActionLink("Gerar Relatório", "ReportPessoaMoradia")%>
</p>
<table id="table">
    <tr>
        <th>
            <%: Models.App_GlobalResources.Mensagem.nome_pessoa %>
        </th>
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
            <%: Models.App_GlobalResources.Mensagem.tipo %>
        </th>
        <th><%: Models.App_GlobalResources.Mensagem.opcoes %></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomePessoa) %>
        </td>
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
            <%: Html.DisplayFor(modelItem => item.Tipo) %>
        </td>
        <td>
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { idPessoa = item.IdPessoa, idMoradia = item.IdMoradia })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.apagar, "Delete", new { idPessoa = item.IdPessoa, idMoradia = item.IdMoradia })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
