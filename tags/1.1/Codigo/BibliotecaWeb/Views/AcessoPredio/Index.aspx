<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.AcessoPredioModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.acesso %></h2>

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.registrarAcesso, "Create") %>
</p>
<table id="table">
    <tr>
       
        <th>
            <%: Models.App_GlobalResources.Mensagem.codigoPessoa %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.dataEntrada %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.dataSaida %>
        </th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
       
        <td>
            <%: Html.DisplayFor(modelItem => item.IdPessoa) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.DataEntrada) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.DataSaida) %>
        </td>

    </tr>
<% } %>

</table>

</asp:Content>
