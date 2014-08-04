<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.ComentarioModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%:Models.App_GlobalResources.Mensagem.comentarios%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <%:Models.App_GlobalResources.Mensagem.comentarios%></h2>
    <table id="table">
        <tr>
            <th>
                <%: Models.App_GlobalResources.Mensagem.nomePessoa %>
            </th>
            <th>
                <%: Models.App_GlobalResources.Mensagem.comentario %>
            </th>
            <th>
                <%: Models.App_GlobalResources.Mensagem.data %>
            </th>
            <th>
                <%: Models.App_GlobalResources.Mensagem.status %>
            </th>
            <th>
            </th>
        </tr>
        <% foreach (var item in Model)
           { %>
        <tr>
            <td>
                <%: Html.DisplayFor(modelItem => item.NomePessoa) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Comentario) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Data) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Status) %>
            </td>
            <td>
                <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.detalhes, "Details", new { id = item.IdPostagem })%>
            </td>
        </tr>
        <% } %>
    </table>
</asp:Content>
