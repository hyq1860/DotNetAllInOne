// JavaScript Document
var $page;
$(document).on("pagecreate", function(e) {
	$page = $(e.target);
	var pageId = $page.attr("id");
	//¼ÓÔØµ×²¿²Ëµ¥
	createFooter($page,pageId);
	pageRefresh();
});