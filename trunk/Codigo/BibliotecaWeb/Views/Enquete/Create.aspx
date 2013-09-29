<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.OpcoesEnqueteModel>" %>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <%: Models.App_GlobalResources.Mensagem.enquete %></h2>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"
        type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.simple-dtpicker.js") %>" type="text/javascript"></script>
    <script src="../../Scripts/jquery-enquete.js" type="text/javascript"></script>
    <link href="../../Content/themes/base/jquery.simple-dtpicker.css" rel="stylesheet"
        type="text/css" />
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>
            <%: Models.App_GlobalResources.Mensagem.enquete %></legend>
        
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Enquete.Titulo)%>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Enquete.Titulo)%>
            <%: Html.ValidationMessageFor(model => model.Enquete.Titulo)%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Enquete.Descricao)%>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Enquete.Descricao)%>
            <%: Html.ValidationMessageFor(model => model.Enquete.Descricao)%>
        </div>

        <div style="float: left;">
         <fieldset>
        <legend> Opções </legend>

        <a  href="javascript:addRow();">Adicionar opção</a>
        <table id="formTable">
            <thead>
                <tr>
                    <th>
                        
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        Opção 1:
                        <%: Html.EditorFor(model => model.Opcoes[0].Descricao)%>
                        <%: Html.ValidationMessageFor(model => model.Opcoes[0].Descricao)%>
                    </td>
                </tr>
                <tr>
                
                    <td>
                        Opção 2:
                        <%: Html.EditorFor(model => model.Opcoes[1].Descricao)%>
                        <%: Html.ValidationMessageFor(model => model.Opcoes[1].Descricao)%>
                    </td>
                </tr>
            </tbody>
        </table>
        </fieldset>
        </div>


        <div class="editor-label">
            <%: Html.LabelFor(model => model.Enquete.DataInicio)%>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.Enquete.DataInicio, new { @class = "date", @type = "date" })%>
            <%: Html.ValidationMessageFor(model => model.Enquete.DataInicio)%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Enquete.DataFim)%>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.Enquete.DataFim, new { @class = "date", @type = "date" })%>
            <%: Html.ValidationMessageFor(model => model.Enquete.DataFim)%>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Enquete.IdStatusEnquete)%>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.Enquete.IdStatusEnquete, ViewBag.IdStatusEnquete as SelectList)%>
            <%: Html.ValidationMessageFor(model => model.Enquete.IdStatusEnquete)%>
        </div>
        <p>
           
        </p>
    </fieldset>
     <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.salvar %>" />
    </div>
    <% } %>
    <div>
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Index")%>
    </div>
</asp:Content>
