<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.OcorrenciaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%:Models.App_GlobalResources.Mensagem.novoRegistroOcorrencia%></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%:Models.App_GlobalResources.Mensagem.novo%> </legend>
           
       
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
            <%: Html.TextBoxFor(model => model.Data, new { @class = "date", @type = "date" })%>
            <%: Html.ValidationMessageFor(model => model.Data) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.IdTipoOcorrencia) %>
        </div>
        <p>
             <%: Html.DropDownListFor(model => model.IdTipoOcorrencia, ViewBag.IdTipoOcorrencia as SelectList)%>
              <%: Html.ValidationMessageFor(model => model.IdTipoOcorrencia)%>
        </p>    

        <div class="editor-label">
            <%: Html.LabelFor(model => model.IdStatusOcorrenicia) %>
        </div>
        <p>
             <%: Html.DropDownListFor(model => model.IdStatusOcorrenicia, ViewBag.IdStatusOcorrencia as SelectList)%>
              <%: Html.ValidationMessageFor(model => model.IdStatusOcorrenicia)%>
        </p>  

       
        <p>
            <input type="submit" value=<%: Models.App_GlobalResources.Mensagem.salvar %> /> 
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
</div>

</asp:Content>
