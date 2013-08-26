<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.AreaPublicaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.listaAreasPublicas %></h2>

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.novo, "Create") %>
</p>
<table id="table">
    <tr>
        
        <th>
              <%: Models.App_GlobalResources.Mensagem.condominio %>
        </th>
        
        <th>
              <%: Models.App_GlobalResources.Mensagem.nome %>

        </th>
        <th>
              <%: Models.App_GlobalResources.Mensagem.local %>
        </th>
        <th>

              <%: Models.App_GlobalResources.Mensagem.estado %>

        </th>
        <th>
          <%: Models.App_GlobalResources.Mensagem.tamanho %>

        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.valorPagamento %>

        </th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
       
        <td>
            <%: Html.DisplayFor(modelItem => item.IdCondominio) %>
        </td>
       
        <td>
            <%: Html.DisplayFor(modelItem => item.Nome) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Local) %>
        </td>
         <td>
            <%: Html.DisplayFor(modelItem => item.IdStatus) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Tamanho) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.ValorReserva) %>
        </td>
        <td>
         <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = item.IdAreaPublica })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.detalhes, "Details", new { id = item.IdAreaPublica })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.apagar, "Delete", new { id = item.IdAreaPublica })%>

        </td>
    </tr>
<% } %>

</table>

</asp:Content>
