// JavaScript Document

function addLoadEvent(func) {
    var oldonload = window.onload;
    if (typeof window.onload != 'function') {
        window.onload = func;
    } else {
        window.onload = function () {
            oldonload();
            func();
        }
    }
}

/////////////////////////////////////carousel轮播插件///////////////////////////////////////////////////////////////////
 $(function () {
    $('.carousel').carousel();
  });
/////////////////////////////////////////////////////////////////////////////////