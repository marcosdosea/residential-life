<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%
    if (Request.IsAuthenticated) {
%>
        Bem-Vindo <strong><%: Page.User.Identity.Name %></strong>!
        [ <%: Html.ActionLink("Log Off", "LogOff", "Account") %> ]
        <p id="perfil"><%: Html.Label("Perfil: " + Session["_Perfil"].ToString())%></p>
<%
    }
    else {
%> 
        [ <%: Html.ActionLink("Log On", "LogOn", "Account") %> ]
<%
    }
%>

<style>
    #perfil
    {
        font-size: smaller
    }
</style>
