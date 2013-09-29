<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.VotoEnqueteModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    VotarEnquete
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        VotarEnquete</h2>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>
    <INPUT TYPE="hidden" NAME="IdEnquete" VALUE="<%: ViewBag.IdEnquete %>">

    <fieldset>
        <legend>
        <%:ViewBag.Enquete.Titulo %></legend>
        <%:ViewBag.Enquete.Descricao %>

        <% foreach (var item in ViewBag.IdOpcao)
           {%>
        <p>
            <input id="IdOpcao" name="IdOpcao" type="radio" value="<%: item.IdOpcao %>">
            <%: item.Descricao %>
        </p>
        <%    }
        %>
        <input type="submit" value="Votar" />
        <% } %>
</asp:Content>
