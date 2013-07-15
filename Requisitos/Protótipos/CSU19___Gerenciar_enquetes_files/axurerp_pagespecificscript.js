for(var i = 0; i < 101; i++) { var scriptId = 'u' + i; window[scriptId] = document.getElementById(scriptId); }

$axure.eventManager.pageLoad(
function (e) {

});
gv_vAlignTable['u86'] = 'top';gv_vAlignTable['u51'] = 'top';
u25.style.cursor = 'pointer';
$axure.eventManager.click('u25', function(e) {

if (true) {

	NewWindow("resources/Other.html#other=" + encodeURI("Fazer telinha pra digitar nome do campo"), "", "directories=0, height=300, location=0, menubar=0, resizable=1, scrollbars=1, status=0, toolbar=0, width=300", true, 300, 300);

}
});
gv_vAlignTable['u16'] = 'top';u93.tabIndex = 0;

u93.style.cursor = 'pointer';
$axure.eventManager.click('u93', function(e) {

if (true) {

	self.location.href=$axure.globalVariableProvider.getLinkUrl('CSU17___Gerenciar_Reservas_de_Ambientes.html');

}
});
gv_vAlignTable['u93'] = 'top';gv_vAlignTable['u8'] = 'top';gv_vAlignTable['u32'] = 'top';
u53.style.cursor = 'pointer';
$axure.eventManager.click('u53', function(e) {

if (true) {

	self.location.href=$axure.globalVariableProvider.getLinkUrl('Menu_Sindico.html');

}
});
document.getElementById('u87_img').tabIndex = 0;

u87.style.cursor = 'pointer';
$axure.eventManager.click('u87', function(e) {

if (true) {

	self.location.href=$axure.globalVariableProvider.getLinkUrl('CSU22___Autentica_ao.html');

}
});
gv_vAlignTable['u1'] = 'center';gv_vAlignTable['u38'] = 'top';gv_vAlignTable['u68'] = 'top';gv_vAlignTable['u30'] = 'top';gv_vAlignTable['u60'] = 'top';gv_vAlignTable['u17'] = 'top';gv_vAlignTable['u64'] = 'top';u100.tabIndex = 0;

u100.style.cursor = 'pointer';
$axure.eventManager.click('u100', function(e) {

if (true) {

	self.location.href=$axure.globalVariableProvider.getLinkUrl('CSU06___Gerenciar_cadastro_do_proprietario.html');

}
});
gv_vAlignTable['u100'] = 'top';gv_vAlignTable['u58'] = 'top';
u79.style.cursor = 'pointer';
$axure.eventManager.click('u79', function(e) {

if (true) {

	self.location.href=$axure.globalVariableProvider.getLinkUrl('Menu_Sindico.html');

}
});
u97.tabIndex = 0;

u97.style.cursor = 'pointer';
$axure.eventManager.click('u97', function(e) {

if (true) {

	self.location.href=$axure.globalVariableProvider.getLinkUrl('CSU07___Gerenciar_Funcionarios.html');

}
});
gv_vAlignTable['u97'] = 'top';gv_vAlignTable['u41'] = 'top';gv_vAlignTable['u15'] = 'top';gv_vAlignTable['u45'] = 'top';gv_vAlignTable['u36'] = 'top';gv_vAlignTable['u66'] = 'top';gv_vAlignTable['u37'] = 'top';u92.tabIndex = 0;

u92.style.cursor = 'pointer';
$axure.eventManager.click('u92', function(e) {

if (true) {

	self.location.href=$axure.globalVariableProvider.getLinkUrl('Copy_of_CSU23___Visualizar_movimenta_ao_financeira.html');

}
});
gv_vAlignTable['u92'] = 'top';document.getElementById('u83_img').tabIndex = 0;

u83.style.cursor = 'pointer';
$axure.eventManager.click('u83', function(e) {

if (true) {

	SetPanelState('u11', 'pd1u11','none','',500,'none','',500);

}
});
u95.tabIndex = 0;

u95.style.cursor = 'pointer';
$axure.eventManager.click('u95', function(e) {

if (true) {

	self.location.href=$axure.globalVariableProvider.getLinkUrl('CSU16___Gerenciar_ocorrencias.html');

}
});
gv_vAlignTable['u95'] = 'top';gv_vAlignTable['u13'] = 'top';
u52.style.cursor = 'pointer';
$axure.eventManager.click('u52', function(e) {

if (true) {

	SetPanelState('u11', 'pd4u11','none','',500,'none','',500);

}
});
gv_vAlignTable['u3'] = 'center';
u27.style.cursor = 'pointer';
$axure.eventManager.click('u27', u27Click);
InsertAfterBegin(document.body, "<div class='intcases' id='u27LinksClick'></div>")
var u27LinksClick = document.getElementById('u27LinksClick');
function u27Click(e) 
{
windowEvent = e;


	ToggleLinks(e, 'u27LinksClick');
}

InsertBeforeEnd(u27LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u27Clicku1c5cad62875d4873abb34b926a8fbac4(event)'>enquete criada</div>");
function u27Clicku1c5cad62875d4873abb34b926a8fbac4(e)
{

	SetPanelState('u29', 'pd0u29','none','',500,'none','',500);

	ToggleLinks(e, 'u27LinksClick');
}

InsertBeforeEnd(u27LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u27Clickuc245e3b358fd473481b3072e8d9b809e(event)'>enquete não criada</div>");
function u27Clickuc245e3b358fd473481b3072e8d9b809e(e)
{

	SetPanelState('u29', 'pd1u29','none','',500,'none','',500);

	ToggleLinks(e, 'u27LinksClick');
}

InsertBeforeEnd(u27LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u27Clicku5c61761ef91c45c5835da591bda0726b(event)'>campos em branco</div>");
function u27Clicku5c61761ef91c45c5835da591bda0726b(e)
{

	SetPanelState('u29', 'pd2u29','none','',500,'none','',500);

	ToggleLinks(e, 'u27LinksClick');
}
gv_vAlignTable['u90'] = 'center';gv_vAlignTable['u84'] = 'top';
u28.style.cursor = 'pointer';
$axure.eventManager.click('u28', function(e) {

if (true) {

	NewWindow("resources/Other.html#other=" + encodeURI("Opção deve sumir da lista."), "", "directories=0, height=300, location=0, menubar=0, resizable=1, scrollbars=1, status=0, toolbar=0, width=300", true, 300, 300);

}
});
u99.tabIndex = 0;

u99.style.cursor = 'pointer';
$axure.eventManager.click('u99', function(e) {

if (true) {

	self.location.href=$axure.globalVariableProvider.getLinkUrl('Copy_of_CSU02___Gerenciar_espa_os.html');

}
});
gv_vAlignTable['u99'] = 'top';gv_vAlignTable['u39'] = 'top';gv_vAlignTable['u69'] = 'top';gv_vAlignTable['u4'] = 'top';u94.tabIndex = 0;

u94.style.cursor = 'pointer';
$axure.eventManager.click('u94', function(e) {

if (true) {

    self.location.href="resources/reload.html#" + encodeURI($axure.globalVariableProvider.getLinkUrl($axure.pageData.url));

}
});
gv_vAlignTable['u94'] = 'top';gv_vAlignTable['u31'] = 'top';u96.tabIndex = 0;

u96.style.cursor = 'pointer';
$axure.eventManager.click('u96', function(e) {

if (true) {

	self.location.href=$axure.globalVariableProvider.getLinkUrl('CSU20___Gerenciar_emails.html');

}
});
gv_vAlignTable['u96'] = 'top';
u61.style.cursor = 'pointer';
$axure.eventManager.click('u61', function(e) {

if (true) {

	var obj1 = document.getElementById("u61");
    obj1.disabled = true;

}
});
u91.tabIndex = 0;

u91.style.cursor = 'pointer';
$axure.eventManager.click('u91', function(e) {

if (true) {

	self.location.href=$axure.globalVariableProvider.getLinkUrl('CSU12___Publicar_no_mural_eletronico__Sindico_.html');

}
});
gv_vAlignTable['u91'] = 'top';
u35.style.cursor = 'pointer';
$axure.eventManager.click('u35', function(e) {

if (true) {

	SetPanelState('u11', 'pd2u11','none','',500,'none','',500);

}
});

u26.style.cursor = 'pointer';
$axure.eventManager.click('u26', function(e) {

if (true) {

	var obj1 = document.getElementById("u28");
    obj1.disabled = false;

}
});
gv_vAlignTable['u65'] = 'top';gv_vAlignTable['u56'] = 'top';gv_vAlignTable['u82'] = 'top';gv_vAlignTable['u12'] = 'top';document.getElementById('u9_img').tabIndex = 0;

u9.style.cursor = 'pointer';
$axure.eventManager.click('u9', function(e) {

if (true) {

	SetPanelState('u11', 'pd2u11','none','',500,'none','',500);

}
});
gv_vAlignTable['u42'] = 'top';
u33.style.cursor = 'pointer';
$axure.eventManager.click('u33', function(e) {

if (true) {

	SetPanelState('u11', 'pd0u11','none','',500,'none','',500);

}
});

u72.style.cursor = 'pointer';
$axure.eventManager.click('u72', function(e) {

if (true) {

}
});

u63.style.cursor = 'pointer';
$axure.eventManager.click('u63', function(e) {

if (true) {

	SetPanelState('u11', 'pd0u11','none','',500,'none','',500);

}
});

u78.style.cursor = 'pointer';
$axure.eventManager.click('u78', function(e) {

if (true) {

	SetPanelState('u11', 'pd4u11','none','',500,'none','',500);

}
});
document.getElementById('u7_img').tabIndex = 0;

u7.style.cursor = 'pointer';
$axure.eventManager.click('u7', function(e) {

if (true) {

	SetPanelState('u11', 'pd0u11','none','',500,'none','',500);

}
});
document.getElementById('u57_img').tabIndex = 0;

u57.style.cursor = 'pointer';
$axure.eventManager.click('u57', function(e) {

if (true) {

	SetPanelState('u11', 'pd3u11','none','',500,'none','',500);

}
});
gv_vAlignTable['u10'] = 'top';gv_vAlignTable['u40'] = 'top';gv_vAlignTable['u70'] = 'top';gv_vAlignTable['u14'] = 'top';gv_vAlignTable['u18'] = 'top';gv_vAlignTable['u44'] = 'top';gv_vAlignTable['u88'] = 'center';u98.tabIndex = 0;

u98.style.cursor = 'pointer';
$axure.eventManager.click('u98', function(e) {

if (true) {

	self.location.href=$axure.globalVariableProvider.getLinkUrl('Copy_of_CSU03___Gerenciar_Central_de_atendimento.html');

}
});
gv_vAlignTable['u98'] = 'top';gv_vAlignTable['u67'] = 'top';