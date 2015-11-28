

$(document).ready(function () {
    i = document.getElementById("ContentPlaceHolderMain_temp").value;
    var currentTime = 0;
    si = setInterval(function () {
        {
            var h = Math.floor(i / 60);
            $("#time0").html(Math.floor(currentTime / 3600));
            $("#time1").html(h % 60);
            $("#time2").html(currentTime++ % 60);
            i++;
        };
    }, 1000);
    $("#complete").click(function () {
        clearInterval(si);
        var element = "<div id='finish' class='alert alert-success'>" +
        "<button class='close' data-dismiss='alert' type='button'>×</button>" +
        "<h2>您总共<span id='time3'></span></h2><a class='btn btn-success' href='study4-2.aspx?time=" + i + "'>进入下一关</a>" +
        "&nbsp<a class='btn' href=javascript:void(location.reload())'>不服！再来一次</a></div>";
        $("#complete").after(element);
        time3.innerHTML = "用时" + Math.floor(i / 3600) + "小时" + Math.floor(i / 60) + "分" + i % 60 + "秒";
        $("#finish").fadeIn();
    });
});
//


$(document).ready(function () {
    $("#tip1").click(function () {
        $("#goal1").fadeIn();
    });
    $("#tip2").click(function(){
        $("#goal2").fadeIn();
    })
    $("#tip3").click(function () {
        $("#task3").fadeIn();
    })
    $("#tip4").click(function () {
        $("#goal4").fadeIn();
    })
});
$(document).ready(function () {
    $("#goal1").click(function () {
        $("#g1").fadeIn();
        $("#task1").fadeIn();
    });
    $("#goal2").click(function(){
        $("#g2").fadeIn();
        $("#task2").fadeIn();
    })
  
    $("#goal4").click(function () {
        $("#g4").fadeIn();
        $("#task4").fadeIn();
    })
});
$(document).ready(function(){
    $("#task1").click(function(){
        $("#ContentPlaceHolderMain_result1").fadeIn();
    })
    $("#task2").click(function(){
        $("#ContentPlaceHolderMain_result2").fadeIn();
    })
    $("#task3").click(function () {
        $("#ContentPlaceHolderMain_result3").fadeIn();
    })
    $("#task4").click(function () {
        $("#ContentPlaceHolderMain_result4").fadeIn();
    })
})

//
$(document).ready(function () {
    $("#task1").click(function () {
        $.layer({
            type: 1,   //0-4的选择,
            title: false,
            border: [0],
            shade: [1],
            closeBtn: [0],
            shadeClose: true,
            area: ['0px', '0px'],
            page: {
                html: '<div id="box"><h5 class = "title">'+t5+'</h5></div>' //此处放了防止html被解析，用了\转义，实际使用时可去掉(已改)
            }
        });
    })
})
$(document).ready(function () {
    $("#task2").click(function () {
        $.layer({
            type: 1,   //0-4的选择,
            title: false,
            border: [0],
            shade: [1],
            closeBtn: [0],
            shadeClose: true,
            area: ['0px', '0px'],
            page: {
                html: '<div id="box"><h5 class = "title">'+t6+'</h5> </div>' //此处放了防止html被解析，用了\转义，实际使用时可去掉(已改)
            }
        });
    })
})
$(document).ready(function () {
    $("#task3").click(function () {
        $.layer({
            type: 1,   //0-4的选择,
            title: false,
            border: [0],
            shade: [1],
            closeBtn: [0],
            shadeClose: true,
            area: ['0px', '0px'],
            page: {
                html: '<div id="box"><h5 class = "title">'+t7+' </h5> </div>' //此处放了防止html被解析，用了\转义，实际使用时可去掉(已改)
            }
        });
    })
})
$(document).ready(function () {
    $("#task4").click(function () {
        $.layer({
            type: 1,   //0-4的选择,
            title: false,
            border: [0],
            shade: [1],
            closeBtn: [0],
            shadeClose: true,
            area: ['0px', '0px'],
            page: {
                html: '<div id="box"><h5 class = "title">'+t8+'</h5> </div>' //此处放了防止html被解析，用了\转义，实际使用时可去掉(已改)
            }
        });
    })
})
$(document).ready(function () {
    $("#lijie").on("click", function () {
        var oBox = document.getElementById("drag");
        var oTitle = document.getElementById("drag");
        var oDrag = new Drag(oBox, { handle: oTitle, limit: false });
    });
});
$('#lijie').on('click', function () {
    var pageii = $.layer({
        type: 1,
        title: false,
        area: ['0', '0'],
        border: [0], //去掉默认边框
        shade: [0], //去掉遮罩
        closeBtn: [0, false], //去掉默认关闭按钮
        //shift: 'right', //从左动画弹出
        page: {
            html: '<div id="drag" style="width:400px; height:400px; padding:20px; border:1px solid #ccc; background-color:#eee;"><img src="questionpic/lijietimu.png"> <button id="pagebtn" class="btns" onclick="">关闭<button></div>'
        }
    });

    //自设关闭
    $('#pagebtn').on('click', function () {
        layer.close(pageii);
    });
});


function Drag() {
    //初始化
    this.initialize.apply(this, arguments);
}
Drag.prototype = {
    //初始化
    initialize: function (drag, options) {
        this.drag = this.$(drag);
        this._x = this._y = 0;
        this._moveDrag = this.bind(this, this.moveDrag);
        this._stopDrag = this.bind(this, this.stopDrag);

        this.setOptions(options);
        this.handle = this.$(this.options.handle);
        this.maxContainer = this.$(this.options.maxContainer);

        this.maxTop = Math.max(this.maxContainer.clientHeight, this.maxContainer.scrollHeight) - this.drag.offsetHeight;
        this.maxLeft = Math.max(this.maxContainer.clientWidth, this.maxContainer.scrollWidth) - this.drag.offsetWidth;

        this.limit = this.options.limit;
        this.lockX = this.options.lockX;
        this.lockY = this.options.lockY;
        this.lock = this.options.lock;

        this.onStart = this.options.onStart;
        this.onMove = this.options.onMove;
        this.onStop = this.options.onStop;

        this.handle.style.cursor = "move";

        this.changeLayout();

        this.addHandler(this.handle, "mousedown", this.bind(this, this.startDrag))
    },
    changeLayout: function () {
        this.drag.style.top = this.drag.offsetTop + "px";
        this.drag.style.left = this.drag.offsetLeft + "px";
        this.drag.style.position = "absolute";
        this.drag.style.margin = "0"
    },
    startDrag: function (event) {
        var event = event || window.event;

        this._x = event.clientX - this.drag.offsetLeft;
        this._y = event.clientY - this.drag.offsetTop;

        this.addHandler(document, "mousemove", this._moveDrag);
        this.addHandler(document, "mouseup", this._stopDrag);

        event.preventDefault && event.preventDefault();
        this.handle.setCapture && this.handle.setCapture();

        this.onStart()
    },
    moveDrag: function (event) {
        var event = event || window.event;

        var iTop = event.clientY - this._y;
        var iLeft = event.clientX - this._x;

        if (this.lock) return;

        this.limit && (iTop < 0 && (iTop = 0), iLeft < 0 && (iLeft = 0), iTop > this.maxTop && (iTop = this.maxTop), iLeft > this.maxLeft && (iLeft = this.maxLeft));

        this.lockY || (this.drag.style.top = iTop + "px");
        this.lockX || (this.drag.style.left = iLeft + "px");

        event.preventDefault && event.preventDefault();

        this.onMove()
    },
    stopDrag: function () {

        this.removeHandler(document, "mousemove", this._moveDrag);
        this.removeHandler(document, "mouseup", this._stopDrag);

        this.handle.releaseCapture && this.handle.releaseCapture();

        this.onStop()
    },
    //参数设置
    setOptions: function (options) {
        this.options =
        {
            handle: this.drag, //事件对象
            limit: true, //锁定范围
            lock: false, //锁定位置
            lockX: false, //锁定水平位置
            lockY: false, //锁定垂直位置
            maxContainer: document.documentElement || document.body, //指定限制容器
            onStart: function () { }, //开始时回调函数
            onMove: function () { }, //拖拽时回调函数
            onStop: function () { }  //停止时回调函数
        };
        for (var p in options) this.options[p] = options[p]
    },
    //获取id
    $: function (id) {
        return typeof id === "string" ? document.getElementById(id) : id
    },
    //添加绑定事件
    addHandler: function (oElement, sEventType, fnHandler) {
        return oElement.addEventListener ? oElement.addEventListener(sEventType, fnHandler, false) : oElement.attachEvent("on" + sEventType, fnHandler)
    },
    //删除绑定事件
    removeHandler: function (oElement, sEventType, fnHandler) {
        return oElement.removeEventListener ? oElement.removeEventListener(sEventType, fnHandler, false) : oElement.detachEvent("on" + sEventType, fnHandler)
    },
    //绑定事件到对象
    bind: function (object, fnHandler) {
        return function () {
            return fnHandler.apply(object, arguments)
        }
    }
};
//应用

$(document).ready(function () {
    $(".task").on("click", function () {
        var oBox = document.getElementById("box");
        var oTitle = oBox.getElementsByTagName("h5")[0];
        var oDrag = new Drag(oBox, { handle: oTitle, limit: false });
    });
});
//
function transferValue(tagName, objectId) {           //把name为tagName的radio中的选中的文本传给id为objectId的span标签
    var radios = document.getElementsByName(tagName);
    var tag = false;
    var val;
    for (var i = 0; radios[i]; i++) {
        if (radios[i].checked) {
            tag = true;
            rad = radios[i];
            var $val = rad.nextSibling;            //当前标签的下一标签
            val = $val.innerHTML;
            break;
        }
    }
    var result = document.getElementById(objectId);
    if (tag) {
        result.innerHTML = val;
    }
    else {
        result.innerHTML = "wrong!";
    }
}
$(document).ready(function () {
    counter = 1;
    for (var a = 1; a <= 4; a++) {
        $("#ContentPlaceHolderMain_tip" + a)[0].style.color = "gray";
    }
    $("#ContentPlaceHolderMain_tip1")[0].style.color = "blue";   
});
$(document).ready(function () {       
    $('input:radio[name="ctl00$ContentPlaceHolderMain$resultsel"]').click(function () {
        if (counter == 1) { transferValue("ctl00$ContentPlaceHolderMain$resultsel", "ContentPlaceHolderMain_result1") }
        else if (counter == 2) { transferValue("ctl00$ContentPlaceHolderMain$resultsel", "ContentPlaceHolderMain_result2") }
        else if (counter == 3) { transferValue("ctl00$ContentPlaceHolderMain$resultsel", "ContentPlaceHolderMain_sguanxi") }
        else if (counter == 4) { transferValue("ctl00$ContentPlaceHolderMain$resultsel", "ContentPlaceHolderMain_result4") }
    })
    $('input:radio[name="ctl00$ContentPlaceHolderMain$zhuangtaisel"]').click(function () {
        if (counter == 3) { transferValue("ctl00$ContentPlaceHolderMain$zhuangtaisel", "ContentPlaceHolderMain_szhuangtai") }
    })
    $('input:radio[name="ctl00$ContentPlaceHolderMain$formulasel"]').click(function () {
        if (counter == 3) { transferValue("ctl00$ContentPlaceHolderMain$formulasel", "ContentPlaceHolderMain_sformula") }
    })
    $('input:radio[name="ctl00$ContentPlaceHolderMain$kejiesel"]').click(function () {
        if (counter == 3) { transferValue("ctl00$ContentPlaceHolderMain$kejiesel", "ContentPlaceHolderMain_skejie") }
    })
})
$(document).ready(function () {       
        
    $("#yes").click(function () {
        if (counter == 1) {
            var value1 = $("#ContentPlaceHolderMain_result1")[0].innerHTML;
            var val1 = $("#ContentPlaceHolderMain_resultsel_0")[0].nextSibling.innerHTML;
            if (value1 != val1) {
                alert("表达结果1的关系式选错，请重新选择");
                return;
            } else {
                $("#ContentPlaceHolderMain_ps0").fadeOut();
                $("#ContentPlaceHolderMain_ps1").fadeIn(2000);
                $("#ContentPlaceHolderMain_result1").fadeOut();
                //$("#task2").fadeIn();
                $("#goal2").fadeIn();
                counter++;
                $("#ContentPlaceHolderMain_tip1")[0].style.color = "black";//使下一条题目变量，本条题目变黑
                $("#ContentPlaceHolderMain_tip" + counter)[0].style.color = "blue";
            }           
        }

       else if (counter == 2) {
           var value2 = $("#ContentPlaceHolderMain_result2")[0].innerHTML;
           var val2 = $("#ContentPlaceHolderMain_resultsel_1")[0].nextSibling.innerHTML;
            if (value2 != val2) {
                alert("表达结果2的关系式的关系式选错，请重新选择");
                return;
            } else {
                $("#ContentPlaceHolderMain_ps1").fadeOut();
                $("#ContentPlaceHolderMain_ps2").fadeIn(2000);
                $("#ContentPlaceHolderMain_result2").fadeOut();
                $("#task3").fadeIn();
                counter++;
                $("#ContentPlaceHolderMain_tip2")[0].style.color = "black";
                $("#ContentPlaceHolderMain_tip" + counter)[0].style.color = "blue";
            }
       }
       else if (counter == 3) {
           var value3_1 = $("#ContentPlaceHolderMain_szhuangtai")[0].innerHTML;
           var value3_2 = $("#ContentPlaceHolderMain_sformula")[0].innerHTML;
           var value3_3 = $("#ContentPlaceHolderMain_sguanxi")[0].innerHTML;
           var value3_4 = $("#ContentPlaceHolderMain_skejie")[0].innerHTML;
           var val3_1 = $("#ContentPlaceHolderMain_zhuangtaisel_4")[0].nextSibling.innerHTML;
           var val3_2 = $("#ContentPlaceHolderMain_formulasel_3")[0].nextSibling.innerHTML;
           var val3_3 = $("#ContentPlaceHolderMain_resultsel_2")[0].nextSibling.innerHTML;
           var val3_4 = $("#ContentPlaceHolderMain_kejiesel_0")[0].nextSibling.innerHTML;
           if (value3_1 != val3_1) {
               alert("状态或过程选错")
           }
           else if (value3_2 != val3_2) {
               alert("公式或规律选错");
               return;
           }
           else if (value3_3 != val3_3) {
               alert("推理得出的关系式选错");
               return;
           }
           else if (value3_4 != val3_4) {
               alert("判断是否可解选错");
               return;
           }
           else  {
               $("#ContentPlaceHolderMain_ps2").fadeOut();
               $("#ContentPlaceHolderMain_ps3").fadeIn(2000);
               $("#g3").fadeIn();
               $("#task4").fadeIn();
               $("#ContentPlaceHolderMain_result3").fadeOut();
               counter++;
               $("#ContentPlaceHolderMain_tip3")[0].style.color = "black";    //使下一条题目变量，本条题目变黑
               $("#ContentPlaceHolderMain_tip" + counter)[0].style.color = "blue";
           }
       }
       else if (counter == 4) {
           var value4 = $("#ContentPlaceHolderMain_result4")[0].innerHTML;
           var val4 = $("#ContentPlaceHolderMain_resultsel_3")[0].nextSibling.innerHTML;
           if (value4 != val4) {
               alert("表达结果4的关系式选错")
           } else {
               $("#ContentPlaceHolderMain_ps3").fadeOut();
               $("#ContentPlaceHolderMain_ps4").fadeIn(2000);
              
               $("#complete").fadeIn();

               $("#ContentPlaceHolderMain_tip4")[0].style.color = "black";

           }
       }
});
});
$(document).ready(function (){
    $("#Button").click(function(){
        if (counter == 1) {
            var $val1 = ContentPlaceHolderMain_resultsel_0.nextSibling;
            var val1 = $val1.innerHTML;
            ContentPlaceHolderMain_result1.innerHTML = val1;
        }
        else if (counter == 2) {
            var $val2 = ContentPlaceHolderMain_resultsel_1.nextSibling;
            var val2 = $val2.innerHTML;
            ContentPlaceHolderMain_result2.innerHTML = val2;
        }
        else if (counter == 3) {
            var $val3_1 = ContentPlaceHolderMain_zhuangtaisel_4.nextSibling;
            var $val3_2 = ContentPlaceHolderMain_formulasel_3.nextSibling;
            var $val3_3 = ContentPlaceHolderMain_resultsel_2.nextSibling;
            var $val3_4 = ContentPlaceHolderMain_kejiesel_0.nextSibling;
            var val3_1 = $val3_1.innerHTML;
            var val3_2 = $val3_2.innerHTML;
            var val3_3 = $val3_3.innerHTML;
            var val3_4 = $val3_4.innerHTML;
            ContentPlaceHolderMain_szhuangtai.innerHTML = val3_1;
            ContentPlaceHolderMain_sformula.innerHTML = val3_2;
            ContentPlaceHolderMain_sguanxi.innerHTML = val3_3;
            ContentPlaceHolderMain_skejie.innerHTML = val3_4;
        }
        else if (counter == 4) {
            var $val4 = ContentPlaceHolderMain_resultsel_3.nextSibling;
            var val4 = $val4.innerHTML;
            ContentPlaceHolderMain_result4.innerHTML = val4;
        }
    })
})
$(document).ready(function (){
    $("#Button2").click(function(){
        if (counter == 1) {
            ContentPlaceHolderMain_result1.innerHTML = "";
        }
        else if (counter == 2) {
            ContentPlaceHolderMain_result2.innerHTML = "";
        }
        else if (counter == 3) {
            ContentPlaceHolderMain_szhuangtai.innerHTML = "";
            ContentPlaceHolderMain_sformula.innerHTML = "";
            ContentPlaceHolderMain_sguanxi.innerHTML = "";
            ContentPlaceHolderMain_skejie.innerHTML = "";
        }
        else if (counter == 4) {
            ContentPlaceHolderMain_result4.innerHTML = "";
           
        }
    })
})
