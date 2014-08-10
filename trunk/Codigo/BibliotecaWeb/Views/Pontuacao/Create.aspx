﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.PontuacaoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.pontuacao %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <%: Models.App_GlobalResources.Mensagem.pontuacao %></h2>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>
            <%: Models.App_GlobalResources.Mensagem.pontuacao %></legend>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Pontuacao) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.Pontuacao)%>
            <%: Html.ValidationMessageFor(model => model.Pontuacao) %>
        </div>
    </fieldset>
    <div>
     <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.salvar %>" />
    </div>
    <% } %>
    <div>
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
    </div>
</asp:Content>
