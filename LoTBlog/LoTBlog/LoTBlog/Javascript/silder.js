/*������ǰҳ����*/
var obj = null;
var As = document.getElementById('topnav').getElementsByTagName('a');
obj = As[0];
for (i = 1; i < As.length; i++) {
    if (window.location.href.indexOf(As[i].href) >= 0)
        obj = As[i];
}
obj.id = 'topnav_current'

/*�ٶȷ�����*/
window._bd_share_config={"common":{"bdSnsKey":{},"bdText":"","bdMini":"2","bdMiniList":["mshare","qzone","tsina","weixin","tqq","tieba","douban","sqq","youdao","sdo","qingbiji","mail","isohu","ty","fbook","twi","linkedin","h163","copy","print"],"bdPic":"","bdStyle":"0","bdSize":"32"},"share":{}};with(document)0[(getElementsByTagName('head')[0]||body).appendChild(createElement('script')).src='http://bdimg.share.baidu.com/static/api/js/share.js?v=89860593.js?cdnversion='+~(-new Date()/36e5)];

/*��Ϣ��Ŀ*/
function dis() {
    $('#msgwrap').css("display", "block");
    setTimeout(msgclose,3000);}
function msgclose() {
    $('#msgwrap').css("display", "none");
}