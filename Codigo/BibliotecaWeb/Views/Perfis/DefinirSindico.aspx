<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.master" Inherits="System.Web.Mvc.ViewPage<Models.PessoaMoradiaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.definirSindico %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.definirSindico%></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%: Models.App_GlobalResources.Mensagem.sindico %></legend>

        <% using (Html.BeginForm("Create", "AlocarPessoaMoradia", FormMethod.Post, null))
         { %>
        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.condominio%>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.IdCondominio, ViewBag.IdCondominio as SelectList, "Selecione", new { onchange = "this.form.submit();" })%>
            <%: Html.ValidationMessageFor(model => model.IdCondominio)%>
        </div>

        <div class="editor-label">
            <%: Models.App_GlobalResources.Mensagem.bloco%>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.IdBloco, ViewBag.IdBloco as SelectList, "Selecione", new { onchange = "this.form.submit();" })%>
            <%: Html.ValidationMessageFor(model => model.IdBloco)%>
        </div>

        <div class="editor-label">
            <%: Html.Label(Models.App_GlobalResources.Mensagem.moradia)%>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.IdMoradia, ViewBag.IdMoradia as SelectList, "Selecione", new { onchange = "this.form.submit();" })%>
            <%: Html.ValidationMessageFor(model => model.IdMoradia) %>
        </div>
        <% } %>
        <div class="editor-label">
            <%: Html.Label(Models.App_GlobalResources.Mensagem.nome_pessoa)%>
        </div>
        <div class="editor-field">
            <%: Html.DropDownList("IdPessoa", "Selecione")%>
            <%: Html.ValidationMessageFor(model => model.IdPessoa) %>
        </div>
        <br />
        <p>
            <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.salvar %>" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar, "Sindico", "Perfis")%>
</div>

</asp:Content>
