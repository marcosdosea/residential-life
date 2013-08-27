<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.OcorrenciaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%:Models.App_GlobalResources.Mensagem.editar%></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%:Models.App_GlobalResources.Mensagem.editar%></legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.IdOcorrencia) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.IdOcorrencia) %>
            <%: Html.ValidationMessageFor(model => model.IdOcorrencia) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.IdPessoa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.IdPessoa) %>
            <%: Html.ValidationMessageFor(model => model.IdPessoa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Titulo) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Titulo) %>
            <%: Html.ValidationMessageFor(model => model.Titulo) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Descricao) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Descricao) %>
            <%: Html.ValidationMessageFor(model => model.Descricao) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Data) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Data) %>
            <%: Html.ValidationMessageFor(model => model.Data) %>
        </div>

       <div class="editor-label">
            <%: Html.LabelFor(model => model.IdTipoOcorrencia) %>
        </div>
        <p>
             <%: Html.DropDownList("IdTipoOcorrencia")%>
              <%: Html.ValidationMessageFor(model => model.IdTipoOcorrencia)%>
        </p>    

        <div class="editor-label">
            <%: Html.LabelFor(model => model.IdStatusOcorrenicia) %>
        </div>
        <p>
             <%: Html.DropDownList("IdStatusOcorrencia")%>
              <%: Html.ValidationMessageFor(model => model.IdStatusOcorrenicia)%>
        </p>  
        </p>    

        
        <p>
            <input type="submit" value=<%: Models.App_GlobalResources.Mensagem.salvar %>  />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
</div>

</asp:Content>
