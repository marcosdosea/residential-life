<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.ComentarioModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Models.App_GlobalResources.Mensagem.postagem %></h2>
    <br />
    <div><b> <%: Models.App_GlobalResources.Mensagem.nomePessoa %>:</b> <%: ViewBag.NomePessoa %> 
    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
    <b><%: Models.App_GlobalResources.Mensagem.tituloPostagem %>:</b> <%: ViewBag.Titulo %></div>
    <br /><h2>
        <%:Models.App_GlobalResources.Mensagem.comentarios%></h2>
    <p>
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.novo, "Create", "Comentario", new { idPostagem = ViewBag.IdPostagem },
                        new { @style = "font-size:small;" })%>
        &nbsp&nbsp&nbsp&nbsp|&nbsp&nbsp&nbsp&nbsp
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.meusComentarios, "MeusComentarios", "Comentario",
                        new { idPostagem = ViewBag.IdPostagem }, new { @style = "font-size:small;" })%>
    </p>
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
                <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.detalhes, "Details", new { id = item.IdComentario })%>
                <% if(item.IdPessoa.Equals(ViewBag.IdPessoaLogada)) { %>
                    |
                    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.apagar, "Delete", new { id = item.IdComentario })%>
                    |
                    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = item.IdComentario })%>
                <% } %>
            </td>
        </tr>
        <% } %>
    </table>
    <div><%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index", "Postagem", null, new { @style = "font-size:small;" })%></div>
</asp:Content>
