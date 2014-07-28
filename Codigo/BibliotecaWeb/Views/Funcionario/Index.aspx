<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.FuncionarioModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
     <%: Models.App_GlobalResources.Mensagem.funcionarios %> 
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2> <%: Models.App_GlobalResources.Mensagem.funcionarios %></h2>

<p>
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.novo, "Create") %>
</p>
<table id="table">
    <tr>
        <th style="width:400px;">
            <%: Models.App_GlobalResources.Mensagem.nomePessoa %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.nomeSetor %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.ocupacao %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.frequencia %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.horarioPermitido %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.pontuacao %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.opcoes %>
        </th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomePessoa)%>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomeSetor)%>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Ocupacao) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Frequencia) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.HorarioPermitido) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Pontuacao) %>
        </td>
        <td>
            <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.editar , "Edit", new {  id = item.IdFuncionario }) %> |
            <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.detalhes, "Details", new {  id = item.IdFuncionario  }) %> |
            <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.apagar, "Delete", new {  id = item.IdFuncionario }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
