for(var i = 0; i < 122; i++) { var scriptId = 'u' + i; window[scriptId] = document.getElementById(scriptId); }

$axure.eventManager.pageLoad(
function (e) {

});
gv_vAlignTable['u42'] = 'top';gv_vAlignTable['u86'] = 'top';gv_vAlignTable['u17'] = 'top';gv_vAlignTable['u25'] = 'top';
u16.style.cursor = 'pointer';
$axure.eventManager.click('u16', function(e) {

if (true) {

	SetPanelState('u3', 'pd0u3','none','',500,'none','',500);

}
});

u55.style.cursor = 'pointer';
$axure.eventManager.click('u55', function(e) {

if (true) {

	SetPanelState('u3', 'pd0u3','none','',500,'none','',500);

}
});
gv_vAlignTable['u33'] = 'top';
u76.style.cursor = 'pointer';
$axure.eventManager.click('u76', function(e) {

if (true) {

	SetPanelState('u3', 'pd2u3','none','',500,'none','',500);

}
});

u6.style.cursor = 'pointer';
$axure.eventManager.click('u6', u6Click);
InsertAfterBegin(document.body, "<div class='intcases' id='u6LinksClick'></div>")
var u6LinksClick = document.getElementById('u6LinksClick');
function u6Click(e) 
{
windowEvent = e;


	ToggleLinks(e, 'u6LinksClick');
}

InsertBeforeEnd(u6LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u6Clicku7f10e967750b4b16b39bc87e6e663a71(event)'>exclusão feita</div>");
function u6Clicku7f10e967750b4b16b39bc87e6e663a71(e)
{

	SetPanelState('u12', 'pd0u12','none','',500,'none','',500);

	ToggleLinks(e, 'u6LinksClick');
}

InsertBeforeEnd(u6LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u6Clickuf89f14fb66424053b7f5f91692f5292e(event)'>exclusão não realizada</div>");
function u6Clickuf89f14fb66424053b7f5f91692f5292e(e)
{

	SetPanelState('u12', 'pd1u12','none','',500,'none','',500);

	ToggleLinks(e, 'u6LinksClick');
}

InsertBeforeEnd(u6LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u6Clicku8823f9619dfa42fcab4aeb121b435f2c(event)'>campos em branco</div>");
function u6Clicku8823f9619dfa42fcab4aeb121b435f2c(e)
{

	SetPanelState('u12', 'pd2u12','none','',500,'none','',500);

	ToggleLinks(e, 'u6LinksClick');
}
gv_vAlignTable['u102'] = 'top';gv_vAlignTable['u1'] = 'center';gv_vAlignTable['u38'] = 'top';gv_vAlignTable['u68'] = 'top';gv_vAlignTable['u104'] = 'top';gv_vAlignTable['u8'] = 'top';gv_vAlignTable['u60'] = 'top';
u111.style.cursor = 'pointer';
$axure.eventManager.click('u111', function(e) {

if (true) {

	var obj1 = document.getElementById("u76");
    obj1.disabled = false;

	var obj1 = document.getElementById("u77");
    obj1.disabled = false;

	var obj1 = document.getElementById("u78");
    obj1.disabled = false;

}
});
gv_vAlignTable['u100'] = 'top';gv_vAlignTable['u106'] = 'top';gv_vAlignTable['u58'] = 'top';
u79.style.cursor = 'pointer';
$axure.eventManager.click('u79', function(e) {

if (true) {

	self.location.href=$axure.globalVariableProvider.getLinkUrl('Menu_AdmSIS.html');

}
});
gv_vAlignTable['u11'] = 'top';gv_vAlignTable['u41'] = 'top';gv_vAlignTable['u71'] = 'top';gv_vAlignTable['u15'] = 'top';
u75.style.cursor = 'pointer';
$axure.eventManager.click('u75', function(e) {

if (true) {

	SetPanelState('u3', 'pd1u3','none','',500,'none','',500);

}
});

u66.style.cursor = 'pointer';
$axure.eventManager.click('u66', u66Click);
InsertAfterBegin(document.body, "<div class='intcases' id='u66LinksClick'></div>")
var u66LinksClick = document.getElementById('u66LinksClick');
function u66Click(e) 
{
windowEvent = e;


	ToggleLinks(e, 'u66LinksClick');
}

InsertBeforeEnd(u66LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u66Clicku9096d081911a4fb69f79312134ede5a1(event)'>cadastro realizado com sucesso</div>");
function u66Clicku9096d081911a4fb69f79312134ede5a1(e)
{

	SetPanelState('u67', 'pd0u67','none','',500,'none','',500);

	ToggleLinks(e, 'u66LinksClick');
}

InsertBeforeEnd(u66LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u66Clickua1976bc5b1b54a7db82dd2aab11a7fcc(event)'>erro no cadastro</div>");
function u66Clickua1976bc5b1b54a7db82dd2aab11a7fcc(e)
{

	SetPanelState('u67', 'pd1u67','none','',500,'none','',500);

	ToggleLinks(e, 'u66LinksClick');
}

InsertBeforeEnd(u66LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u66Clicku88b4f1ba49ba41538d733ab331088312(event)'>campos em branco</div>");
function u66Clicku88b4f1ba49ba41538d733ab331088312(e)
{

	SetPanelState('u67', 'pd2u67','none','',500,'none','',500);

	ToggleLinks(e, 'u66LinksClick');
}
u118.tabIndex = 0;

u118.style.cursor = 'pointer';
$axure.eventManager.click('u118', function(e) {

if (true) {

	self.location.href=$axure.globalVariableProvider.getLinkUrl('CSU02___Gerenciar_espa_os.html');

}
});
gv_vAlignTable['u118'] = 'top';gv_vAlignTable['u92'] = 'top';gv_vAlignTable['u22'] = 'top';gv_vAlignTable['u98'] = 'top';gv_vAlignTable['u52'] = 'top';gv_vAlignTable['u43'] = 'top';gv_vAlignTable['u27'] = 'top';
u109.style.cursor = 'pointer';
$axure.eventManager.click('u109', function(e) {

if (true) {

	var obj1 = document.getElementById("u76");
    obj1.disabled = false;

	var obj1 = document.getElementById("u77");
    obj1.disabled = false;

	var obj1 = document.getElementById("u78");
    obj1.disabled = false;

}
});

u77.style.cursor = 'pointer';
$axure.eventManager.click('u77', function(e) {

if (true) {

	SetPanelState('u3', 'pd3u3','none','',500,'none','',500);

}
});
gv_vAlignTable['u90'] = 'top';gv_vAlignTable['u73'] = 'top';gv_vAlignTable['u23'] = 'top';gv_vAlignTable['u94'] = 'top';u119.tabIndex = 0;

u119.style.cursor = 'pointer';
$axure.eventManager.click('u119', function(e) {

if (true) {

	self.location.href=$axure.globalVariableProvider.getLinkUrl('CSU03___Gerenciar_Central_de_atendimento.html');

}
});
gv_vAlignTable['u119'] = 'top';gv_vAlignTable['u50'] = 'top';gv_vAlignTable['u54'] = 'top';gv_vAlignTable['u14'] = 'top';
u39.style.cursor = 'pointer';
$axure.eventManager.click('u39', function(e) {

if (true) {

	SetPanelState('u3', 'pd3u3','none','',500,'none','',500);

}
});
gv_vAlignTable['u69'] = 'top';
u78.style.cursor = 'pointer';
$axure.eventManager.click('u78', function(e) {

if (true) {

	SetPanelState('u3', 'pd4u3','none','',500,'none','',500);

}
});
gv_vAlignTable['u5'] = 'top';
u4.style.cursor = 'pointer';
$axure.eventManager.click('u4', function(e) {

if (true) {

	SetPanelState('u3', 'pd0u3','none','',500,'none','',500);

}
});
gv_vAlignTable['u96'] = 'top';gv_vAlignTable['u26'] = 'top';gv_vAlignTable['u35'] = 'top';gv_vAlignTable['u56'] = 'top';gv_vAlignTable['u116'] = 'center';gv_vAlignTable['u24'] = 'top';
u105.style.cursor = 'pointer';
$axure.eventManager.click('u105', function(e) {

if (true) {

	var obj1 = document.getElementById("u76");
    obj1.disabled = false;

	var obj1 = document.getElementById("u77");
    obj1.disabled = false;

	var obj1 = document.getElementById("u78");
    obj1.disabled = false;

}
});
document.getElementById('u113_img').tabIndex = 0;

u113.style.cursor = 'pointer';
$axure.eventManager.click('u113', function(e) {

if (true) {

	self.location.href=$axure.globalVariableProvider.getLinkUrl('CSU22___Autentica_ao.html');

}
});
gv_vAlignTable['u82'] = 'top';gv_vAlignTable['u20'] = 'top';gv_vAlignTable['u88'] = 'top';gv_vAlignTable['u112'] = 'top';gv_vAlignTable['u21'] = 'top';
u107.style.cursor = 'pointer';
$axure.eventManager.click('u107', function(e) {

if (true) {

	var obj1 = document.getElementById("u76");
    obj1.disabled = false;

	var obj1 = document.getElementById("u77");
    obj1.disabled = false;

	var obj1 = document.getElementById("u78");
    obj1.disabled = false;

}
});
gv_vAlignTable['u13'] = 'top';gv_vAlignTable['u2'] = 'top';
u37.style.cursor = 'pointer';
$axure.eventManager.click('u37', function(e) {

if (true) {

	SetPanelState('u3', 'pd0u3','none','',500,'none','',500);

}
});
gv_vAlignTable['u110'] = 'top';gv_vAlignTable['u7'] = 'top';gv_vAlignTable['u57'] = 'top';gv_vAlignTable['u84'] = 'top';gv_vAlignTable['u40'] = 'top';gv_vAlignTable['u70'] = 'top';
u18.style.cursor = 'pointer';
$axure.eventManager.click('u18', u18Click);
InsertAfterBegin(document.body, "<div class='intcases' id='u18LinksClick'></div>")
var u18LinksClick = document.getElementById('u18LinksClick');
function u18Click(e) 
{
windowEvent = e;


	ToggleLinks(e, 'u18LinksClick');
}

InsertBeforeEnd(u18LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u18Clicku72895bdf791f4340a2615fc6f8fe95b7(event)'>cadastro realizado com sucesso</div>");
function u18Clicku72895bdf791f4340a2615fc6f8fe95b7(e)
{

	SetPanelState('u19', 'pd0u19','none','',500,'none','',500);

	ToggleLinks(e, 'u18LinksClick');
}

InsertBeforeEnd(u18LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u18Clicku51e7c9ad8b464c37a2988a05e79b4a62(event)'>erro no cadastro</div>");
function u18Clicku51e7c9ad8b464c37a2988a05e79b4a62(e)
{

	SetPanelState('u19', 'pd1u19','none','',500,'none','',500);

	ToggleLinks(e, 'u18LinksClick');
}

InsertBeforeEnd(u18LinksClick, "<div class='intcaselink' onmouseout='SuppressBubble(event)' onclick='u18Clickucb36ac82e8ed4c529bff55caa582eb75(event)'>campos em branco</div>");
function u18Clickucb36ac82e8ed4c529bff55caa582eb75(e)
{

	SetPanelState('u19', 'pd2u19','none','',500,'none','',500);

	ToggleLinks(e, 'u18LinksClick');
}
gv_vAlignTable['u44'] = 'top';u117.tabIndex = 0;

u117.style.cursor = 'pointer';
$axure.eventManager.click('u117', function(e) {

if (true) {

    self.location.href="resources/reload.html#" + encodeURI($axure.globalVariableProvider.getLinkUrl($axure.pageData.url));

}
});
gv_vAlignTable['u117'] = 'top';gv_vAlignTable['u114'] = 'center';gv_vAlignTable['u59'] = 'top';gv_vAlignTable['u108'] = 'top';gv_vAlignTable['u121'] = 'center';