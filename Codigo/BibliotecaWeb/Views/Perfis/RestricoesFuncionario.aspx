<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.RestricaoAcessoModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.restricoesAcesso%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.restricoesAcesso%></h2>
<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.novaRestricao, "NovaRestricaoFuncionario", "Perfis")%>
</p>
<table id="table">
    <tr>
        <th>
            <%: Models.App_GlobalResources.Mensagem.nome_pessoa %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.dia %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.horaEntrada %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.horaSaida %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.opcoes %>
        </th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomePessoa) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Dia) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.HoraEntrada) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.HoraSaida) %>
        </td>
        <td>
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.removerRestricao, "RemoverRestricaoAcessoFuncionario", "Perfis",
                new { idRestricaoAcesso = item.IdRestricaoAcesso, idMoradia = item.IdMoradia, idPessoa = item.IdPessoa }, 
                new { @style = "font-size:small;" })%>
        </td>
    </tr>
<% } %>
</table>
<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Funcionario")%>
</div>
</asp:Content>
