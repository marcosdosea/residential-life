<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.CondominioModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.condominios %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.condominios %></h2>

<p>
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.novo, "Create") %>
</p>
<table id="table">
    <tr>
     
        <th>
            <%: Models.App_GlobalResources.Mensagem.idSindico %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.nome %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.rua %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.numero %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.bairro %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.complemento %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.cep %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.cidade %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.estado %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
     
        <td>
            <%: Html.DisplayFor(modelItem => item.IdSindico) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Nome) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Rua) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Numero) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Bairro) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Complemento) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Cep) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Cidade) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Estado) %>
        </td>
        <td>
            <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.editar , "Edit", new {  id=item.IdCondominio }) %> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.detalhes, "Details", new { id = item.IdCondominio })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.apagar, "Delete", new { id = item.IdCondominio })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
