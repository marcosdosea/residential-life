<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.OcorrenciaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%:Models.App_GlobalResources.Mensagem.listaRegistroOcorrencia%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2> <%:Models.App_GlobalResources.Mensagem.listaRegistroOcorrencia%></h2> 

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.novo, "Create")%>
</p>
<table id="table">
    <tr>
        <th> 
           <%:  Models.App_GlobalResources.Mensagem.pessoa%>
        </th>
        <th> 
           <%:  Models.App_GlobalResources.Mensagem.titulo%>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.descricao %>
        </th>
        <th>
             <%: Models.App_GlobalResources.Mensagem.data %>
        </th>
        <th>
             <%: Models.App_GlobalResources.Mensagem.tipo %>
        </th>
        <th>
             <%: Models.App_GlobalResources.Mensagem.status %>
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
            <%: Html.DisplayFor(modelItem => item.Data) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.TipoOcorrencia) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.StatusOcorrencia) %>
        </td>
        <td>
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = item.IdOcorrencia })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.detalhes, "Details", new { id = item.IdOcorrencia })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.apagar, "Delete", new { id = item.IdOcorrencia })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
