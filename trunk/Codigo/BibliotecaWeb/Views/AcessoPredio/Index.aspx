<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.AcessoPredioModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.acesso %></h2>

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.registrarAcesso, "Create") %> &nbsp <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.gerarRelatorio, "ReportAcessoPredio")%>
</p>
<table id="table">
    <tr>
       
        <th>
            <%: Models.App_GlobalResources.Mensagem.pessoa %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.cpf %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.data %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.tipo %>
        </th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
       
        <td>
            <%: Html.DisplayFor(modelItem => item.Pessoa) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.CPF) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Data) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.TipoAcesso) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
