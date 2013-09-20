<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.PostagemModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2> <%:Models.App_GlobalResources.Mensagem.postagens%></h2> 

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.novo, "Create")%>
</p>
<table>
    <tr>        
        <th>
                <%: Models.App_GlobalResources.Mensagem.pessoa %>
        </th>
        <th>
                <%: Models.App_GlobalResources.Mensagem.titulo %>
        </th>
        <th>
                <%: Models.App_GlobalResources.Mensagem.descricao %>
        </th>
        <th>
               <%: Models.App_GlobalResources.Mensagem.dataInicio %>
        </th>
        <th>
                <%: Models.App_GlobalResources.Mensagem.dataFim %>
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>       
        <td>
            <%: Html.DisplayFor(modelItem => item.IdPessoa) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.titulo) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.descricao) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.dataPublAutomatica) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.dataExclusaoAutomatica) %>
        </td>
        <td>
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = item.IdPostagem })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.detalhes, "Details", new { id = item.IdPostagem })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.apagar, "Delete", new { id = item.IdPostagem })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
