//全局配置
var global={
	WEBSITE:"http://xxx.com/",
	userId:''
}

//localStorage缓存
var ls = {
	setItem : function (key,value) {
	    localStorage.setItem(key, value);
	},
	getItem : function(key) {
	    return localStorage.getItem(key);
	}
}

//sessionStorage缓存
var ss = {
	setItem : function (key,value) {
	    sessionStorage.setItem(key, value);
	},
	getItem : function(key) {
	    return sessionStorage.getItem(key);
	}
}

//json数据转换
function toObject(value){
	return $.parseJSON(value);
}

function toJson(value){
	return JSON.parse(value);
}

function toString(value){
	return JSON.stringify(value);
}

//在浏览器上显示组装路径
function showUrl(url){
	document.write(url);
}



//页面跳转与返回
function goTo(page) {
	showLoading();
	$.mobile.changePage(page, {
		transition : "slide"
	});
}

function goBack() {
	$.mobile.back();
}

//alert
function myAlert(text) {
	showMyAlert(text);
	setTimeout(hideLoading, 2000);
}

function showMyAlert(text) {
	$.mobile.loadingMessageTextVisible = true;
	$.mobile.showPageLoadingMsg("a", text, true);
}

//loading 加载提示
$( document ).on( "click", ".show-page-loading-msg", function() {
    var $this = $( this ),
        theme = $this.jqmData( "theme" ) || $.mobile.loader.prototype.options.theme,
        msgText = $this.jqmData( "msgtext" ) || $.mobile.loader.prototype.options.text,
        textVisible = $this.jqmData( "textvisible" ) || $.mobile.loader.prototype.options.textVisible,
        textonly = !!$this.jqmData( "textonly" );
        html = $this.jqmData( "html" ) || "";
    $.mobile.loading( "show", {
            text: msgText,
            textVisible: textVisible,
            theme: theme,
            textonly: textonly,
            html: html
    });
})

.on( "click", ".hide-page-loading-msg", function() {
    $.mobile.loading("hide");
});

function showLoading() {
	$.mobile.loading("show");
}

function hideLoading() {
	$.mobile.loading("hide");
}

//页面刷新
function pageRefresh(){
	$.mobile.pageContainer.trigger("create");
}

//加载底部菜单
function createFooter(page,id){
	var footerUrl = page.attr("data-footer");
	if (footerUrl) {
		var footerHtml = '';
		if (!footerHtml) {
			footerHtml = urlLoadContent(footerUrl);
			ss.setItem(footerUrl, footerHtml);
		}

		page.append(footerHtml);
		if(id=='indexPage'){
			var btnState =page.find('a[data-icon="home"]');
			btnState.attr("class","ui-btn-active");
		}else if(id=='subPage'){
			var btnState =page.find('a[data-icon="search"]');
			btnState.attr("class","ui-btn-active");
		}
	}
}

// 通过url加载html内容
var urlLoadContent = function(url) {
	var content = "";
	$.ajax({
		url : url,
		type : 'GET',
		dataType : "html",
		async : false,
		success : function(html, textStatus, xhr) {
			content = html;
		},
		error : function(xhr, textStatus, errorThrown) {
			content = "";
		}
	});
	return content;
};