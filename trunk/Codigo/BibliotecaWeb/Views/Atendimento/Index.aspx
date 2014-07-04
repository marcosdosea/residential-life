<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.AtendimentoModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.atendimento %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.atendimento %></h2>

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.novo, "Create") %>
</p>
<table>
    <tr>
        <th>
            Nome da Pessoa
        </th>
        <th>
            Titulo
        </th>
        <th>
            Descricao
        </th>
        <th>
            StatusAtendimento
        </th>
        <th>Opções</th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomePessoa) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Titulo) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Descricao) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.StatusAtendimento) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new { id=item.IdAtendimento }) %> |
            <%: Html.ActionLink("Details", "Details", new { id=item.IdAtendimento }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { id=item.IdAtendimento }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
