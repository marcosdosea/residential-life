for(var i = 0; i < 38; i++) { var scriptId = 'u' + i; window[scriptId] = document.getElementById(scriptId); }

$axure.eventManager.pageLoad(
function (e) {

});
gv_vAlignTable['u31'] = 'top';document.getElementById('u36_img').tabIndex = 0;

u36.style.cursor = 'pointer';
$axure.eventManager.click('u36', function(e) {

if (true) {

    self.location.href="resources/reload.html#" + encodeURI($axure.globalVariableProvider.getLinkUrl($axure.pageData.url));

}
});
gv_vAlignTable['u16'] = 'top';
u3.style.cursor = 'pointer';
$axure.eventManager.click('u3', function(e) {

if (true) {

	SetPanelState('u2', 'pd0u2','none','',500,'none','',500);

}
});
gv_vAlignTable['u29'] = 'top';gv_vAlignTable['u14'] = 'center';
u15.style.cursor = 'pointer';
$axure.eventManager.click('u15', u15Click);
InsertAfterBegin(document.body, "<div class='intcases' id='u15LinksClick'></div>")
var u15LinksClick = document.getElementById('u15LinksClick');
function u15Click(e) 
{
windowEvent = e;


	ToggleLinks(e, 'u15LinksClick');
}

InsertBeforeEnd(u15LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u15Clickufbed5c4e0a8d42b5bfce3f339d208856(event)'>aut válida - adm sistema</div>");
function u15Clickufbed5c4e0a8d42b5bfce3f339d208856(e)
{

	self.location.href=$axure.globalVariableProvider.getLinkUrl('Menu_AdmSIS.html');

	ToggleLinks(e, 'u15LinksClick');
}

InsertBeforeEnd(u15LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u15Clicku37fc5bac6ca246d9b446369cf6141e1b(event)'>Se autenticação falhar</div>");
function u15Clicku37fc5bac6ca246d9b446369cf6141e1b(e)
{

	SetPanelVisibility('u21','','none',500);

	ToggleLinks(e, 'u15LinksClick');
}

InsertBeforeEnd(u15LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u15Clicku5079a1de14514ade8322395e94ebe634(event)'>aut válida - administradora</div>");
function u15Clicku5079a1de14514ade8322395e94ebe634(e)
{

	self.location.href=$axure.globalVariableProvider.getLinkUrl('CSU04___Gerenciar_receitas_despesas.html');

	ToggleLinks(e, 'u15LinksClick');
}

InsertBeforeEnd(u15LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u15Clicku23d754ec6f064dcfbe1e968969fc24ca(event)'>aut válida - morador</div>");
function u15Clicku23d754ec6f064dcfbe1e968969fc24ca(e)
{

	self.location.href=$axure.globalVariableProvider.getLinkUrl('Menu_Morador.html');

	ToggleLinks(e, 'u15LinksClick');
}

InsertBeforeEnd(u15LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u15Clicku88b78cf71568441381f25610dd3928f3(event)'>aut válida - síndico</div>");
function u15Clicku88b78cf71568441381f25610dd3928f3(e)
{

	self.location.href=$axure.globalVariableProvider.getLinkUrl('Menu_Sindico.html');

	ToggleLinks(e, 'u15LinksClick');
}

InsertBeforeEnd(u15LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u15Clickub4bbd8ef4edc464bb9c9730a02b2a8fe(event)'>aut válida - guarita</div>");
function u15Clickub4bbd8ef4edc464bb9c9730a02b2a8fe(e)
{

	self.location.href=$axure.globalVariableProvider.getLinkUrl('Menu_Guarita.html');

	ToggleLinks(e, 'u15LinksClick');
}

InsertBeforeEnd(u15LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u15Clicku78b1a89b0c954032b76047275608444b(event)'>aut válida membro do conselho</div>");
function u15Clicku78b1a89b0c954032b76047275608444b(e)
{

	self.location.href=$axure.globalVariableProvider.getLinkUrl('CSU26____Analisar_movimenta_ao_financeira.html');

	ToggleLinks(e, 'u15LinksClick');
}
gv_vAlignTable['u1'] = 'center';gv_vAlignTable['u37'] = 'top';gv_vAlignTable['u10'] = 'top';gv_vAlignTable['u11'] = 'top';gv_vAlignTable['u9'] = 'top';gv_vAlignTable['u35'] = 'top';
u7.style.cursor = 'pointer';
$axure.eventManager.click('u7', u7Click);
InsertAfterBegin(document.body, "<div class='intcases' id='u7LinksClick'></div>")
var u7LinksClick = document.getElementById('u7LinksClick');
function u7Click(e) 
{
windowEvent = e;


	ToggleLinks(e, 'u7LinksClick');
}

InsertBeforeEnd(u7LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u7Clickuf07fd942b9cf4543901da997b3e2e887(event)'>Se email for válido</div>");
function u7Clickuf07fd942b9cf4543901da997b3e2e887(e)
{

	SetPanelState('u8', 'pd0u8','none','',500,'none','',500);

	ToggleLinks(e, 'u7LinksClick');
}

InsertBeforeEnd(u7LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u7Clickua599e699d3b3421d882322cfb1c3bceb(event)'>Se email não cadastrado</div>");
function u7Clickua599e699d3b3421d882322cfb1c3bceb(e)
{

	SetPanelState('u8', 'pd1u8','none','',500,'none','',500);

	ToggleLinks(e, 'u7LinksClick');
}
gv_vAlignTable['u17'] = 'top';gv_vAlignTable['u23'] = 'center';gv_vAlignTable['u24'] = 'top';
u25.style.cursor = 'pointer';
$axure.eventManager.click('u25', function(e) {

if (true) {

	self.location.href=$axure.globalVariableProvider.getLinkUrl('Home.html');

}
});
u20.tabIndex = 0;

u20.style.cursor = 'pointer';
$axure.eventManager.click('u20', function(e) {

if (true) {

	SetPanelState('u2', 'pd1u2','none','',500,'none','',500);

}
});
gv_vAlignTable['u20'] = 'top';gv_vAlignTable['u5'] = 'top';gv_vAlignTable['u33'] = 'top';gv_vAlignTable['u4'] = 'top';