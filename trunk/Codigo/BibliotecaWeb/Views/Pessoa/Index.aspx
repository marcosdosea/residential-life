<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.PessoaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
<table>
    <tr>
        <th>
            Nome
        </th>
        <th>
            CPF
        </th>
        <th>
            RG
        </th>
        <th>
            Sexo
        </th>
        <th>
            Email
        </th>
        <th>
            Login
        </th>
        <th>
            Senha
        </th>
        <th>
            TelefoneFixo
        </th>
        <th>
            TelefoneCelular
        </th>
        <th>
            Rua
        </th>
        <th>
            Numero
        </th>
        <th>
            Complemento
        </th>
        <th>
            Bairro
        </th>
        <th>
            CEP
        </th>
        <th>
            Cidade
        </th>
        <th>
            Estado
        </th>
        <th>
            Tipo
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
            <%: Html.DisplayFor(modelItem => item.RG) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Sexo) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Email) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Login) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Senha) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.TelefoneFixo) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.TelefoneCelular) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Rua) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Numero) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Complemento) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Bairro) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.CEP) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Cidade) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Estado) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Tipo) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
            <%: Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }) %> |
            <%: Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
