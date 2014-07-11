<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.AreaPublicaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.novaArea %></h2>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.novaArea %></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
         <legend><%: Models.App_GlobalResources.Mensagem.novo %></legend>
                 
        <div class="editor-label">
            <%: Html.LabelFor(model => model.IdCondominio) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("IdCondominio")%>
            <%: Html.ValidationMessageFor(model => model.IdCondominio) %>
        </div>

        
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Nome) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nome) %>
            <%: Html.ValidationMessageFor(model => model.Nome) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Local) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Local) %>
            <%: Html.ValidationMessageFor(model => model.Local) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.IdStatusAreaPublica)%>
        </div>
        <div class="editor-field">
             <%: Html.DropDownList("IdStatusAreaPublica")%>
            <%: Html.ValidationMessageFor(model => model.IdStatusAreaPublica)%>
        </div>


        <div class="editor-label">
            <%: Html.LabelFor(model => model.Tamanho) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Tamanho) %>
            <%: Html.ValidationMessageFor(model => model.Tamanho) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ValorReserva)%>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ValorReserva)%>
            <%: Html.ValidationMessageFor(model => model.ValorReserva)%>
        </div>

        <p>
            <input type="submit" value=<%: Models.App_GlobalResources.Mensagem.salvar %>/>
        </p>
    </fieldset>
<% } %>

<div>
     <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index") %>
</div>

</asp:Content>
