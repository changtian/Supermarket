// JavaScript Document
function jiaotai(){
		var qq = new Array({code:'514206380',key:'219f293182e9aeb3a7116c75b395945d631ae9be683690ce7989de0cc5e5ba9d'},{code:'734990781',key:'1bb0315715003e3bbccc01c039725caa7b266f0f1fb425bd6cd8a021819a9feb045ff8c9e70cace24ff2e0ba5a36bb4d8fda5760698ca0be36e5850274c282ca'},{code:'491123187',key:'5b582ce693b0dd6afe59fff9179b151f05955be32362f51883ae4d12f5332dbdc3c5fb434fc9fe461ca993e0be3c319db2f12e914757d2317d23a7543c63f2a2'},{code:'876715839',key:'9799757d68a54ef1d32252020fe9e1071d13bf321f328c47f7e751cce6de5a77'},{code:'974489554',key:'48d5aa21c67422ff82ee34128593cb9b667118a3121239436d0074d1ea8cea1c'});
	var i=Math.round(Math.random()*10000)%5;
	
	var tempSrc='http://sighttp.qq.com/wpa.js?rantime='+Math.random()+'&sigkey='+qq[i].key;
	var oldscript=document.getElementById('testJs');
	var newscript=document.createElement('script');newscript.setAttribute('type','text/javascript'); 
	newscript.setAttribute('id','testJs');
	newscript.setAttribute('src',tempSrc);
	if(oldscript == null)
	{
		document.body.appendChild(newscript);
	}
	else
	{
		oldscript.parentNode.replaceChild(newscript, oldscript);
	}
	window.open('height=1,width=1','http://sighttp.qq.com/cgi-bin/check?sigkey='+qq[i].key);
	window.open('http://sa.mpsoft.net/da/Interface/QQStatistic.aspx');
	likai();
	}
/*function UpdateData() 
{ 
	var xmlhttp = new ActiveXObject("Microsoft.XMLHTTP"); 
	var serverURL="http://sa.mpsoft.net/da/Interface/QQStatistic.aspx"; 
	xmlhttp.Open("POST",serverURL, false); 
	xmlhttp.Send("adst"); 
	xmlhttp = null; 
} */
	function likai(){
		document.getElementById('lik').style.display='none';
		writeCookie('show_panle',1,1);
	}
	function divscroll(div,top,float,screenwidth,speed,padding){
		var tips=(typeof div == 'string')?document.getElementById(div):div;
		var theTop = top||270;/*����Ĭ�ϸ߶�,Խ��Խ����*/
		var floatPosition = (float=="right")?"right":"left";
		var MinScreenWidth = screenwidth||800;
		var thespeed=speed||50;
		
		var old=theTop;
		var moveTips=function(){
			
			if (window.innerHeight) {
				pos = window.pageYOffset
			}
			else if (document.documentElement && document.documentElement.scrollTop) {
				pos = document.documentElement.scrollTop
			}
			else if (document.body) {
				pos = document.body.scrollTop;
			}
			pos = pos - tips.offsetTop + theTop;
			pos = tips.offsetTop + pos/10;
			if (pos < theTop) pos = theTop;
			if (pos != old) {
				tips.style.top = pos+"px";
			}
			eval("tips.style." + floatPosition + "    = \""+padding+"px\";");
			//if(pos<100) tips.style.top = '100'+"px";
			//if(pos>800) tips.style.top = '800'+"px";
			//tips.style.width    = "160px";
			tips.style.position = "absolute";			
			tips.style.display="";
			old = pos;
			setTimeout(moveTips,thespeed);
		}
		setTimeout(moveTips,thespeed);
	}
	function writeCookie(name, value, minute)
    {
      var expire = "";
      if(minute != null)
      {
          expire = new Date((new Date()).getTime() + minute *30*60000);
          expire = "; expires=" + expire.toGMTString();
      }
        document.cookie = name + "=" + escape(value) + expire;
    }
	function getCookie(c_name)
	{
		if (document.cookie.length>0)
  		{
			c_start=document.cookie.indexOf(c_name + "=");
			if (c_start!=-1)
			{ 
				c_start=c_start + c_name.length+1;
				c_end=document.cookie.indexOf(";",c_start);
				if (c_end==-1)
					c_end=document.cookie.length;
				return decodeURIComponent(document.cookie.substring(c_start,c_end));
			}
		}
		return null;
	}
	//divscroll("leftdiv",530,"left",800,50,0);
	divscroll("rightdiv",400,"right",800,50,5);
	
	var show_panle = getCookie('show_panle');
	if(show_panle==1)
		document.getElementById('lik').style.display='none';
	else
		document.getElementById('lik').style.display='';	


var gaJsHost = (("https:" == document.location.protocol) ? "https://ssl." : "http://www.");
document.write(unescape("%3Cscript src='" + gaJsHost + "google-analytics.com/ga.js' type='text/javascript'%3E%3C/script%3E"));

try {
var pageTracker = _gat._getTracker("UA-6526853-1");
pageTracker._trackPageview();
} 
catch(err){}