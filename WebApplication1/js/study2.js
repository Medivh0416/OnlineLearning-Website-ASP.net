
//==========================================
$(document).ready(function () {
    $("#y").click(function () {
        $("#duixiangx").fadeIn();
        $("#xing").fadeIn();
    });
    $("#yza").click(function () {
        $("#yizhiap").fadeIn();
        $("#yzb").fadeIn();
    })
    $("#yzb").click(function () {
        $("#yizhibp").fadeIn();
        $("#task1").fadeIn();
    })
    $("#yzc").click(function () {
        $("#yizhicp").fadeIn();
        $("#task2").fadeIn();
    })
    $("#yzd").click(function () {
        $("#yizhidp").fadeIn();
        $("#task3").fadeIn();
    })
    $("#yze").click(function () {
        $("#yizhiep").fadeIn();
        $("#yzl").fadeIn();
    })
    $("#yzl").click(function () {
        $("#yzlx").fadeIn();
        $("#wzl1").fadeIn();
    })
    $("#wzl1").click(function () {
        $("#wzl1p").fadeIn();
        $("#task4").fadeIn();
    })
    $("#wzl2").click(function () {
        $("#wzl2p").fadeIn();
        $("#task5").fadeIn();
    })
});
function transferValue(tagName, objectId) {           //把name为tagName的radio中的选中的文本传给id为objectId的span标签
    var radios = document.getElementsByName(tagName);
    var tag = false;
    var val;
    for (var i = 0; radios[i]; i++) {
        if (radios[i].checked) {
            tag = true;
            val = radios[i].value;
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
$(document).ready(counter = 1);      //页面加载给计数器设为1.其中botton1和botton2也可以控制counter
$(document).ready(function () {
    $('input:radio[name="ctl00$ContentPlaceHolderMain$select"]').click(function () {
        if (counter == 1) { transferValue("ctl00$ContentPlaceHolderMain$select", "ContentPlaceHolderMain_result1") }
        else if (counter == 2) { transferValue("ctl00$ContentPlaceHolderMain$select", "ContentPlaceHolderMain_result2") }
        else if (counter == 3) { transferValue("ctl00$ContentPlaceHolderMain$select", "ContentPlaceHolderMain_result3") }
        else if (counter == 4) { transferValue("ctl00$ContentPlaceHolderMain$select", "ContentPlaceHolderMain_result4") }
        else if (counter == 5) { transferValue("ctl00$ContentPlaceHolderMain$select", "ContentPlaceHolderMain_result5") }
    })
})
$(document).ready(function () {
    $("#tishi").click(function () {
        if (counter == 1) {
            var val1 = $("#ContentPlaceHolderMain_select_1").attr('value');
            ContentPlaceHolderMain_result1.innerHTML = val1;
        }
        else if (counter == 2) {
            var val2 = $("#ContentPlaceHolderMain_select_0").attr('value');
            ContentPlaceHolderMain_result2.innerHTML = val2;
        }
        else if (counter == 3) {
            var val3 = $("#ContentPlaceHolderMain_select_4").attr('value');
            ContentPlaceHolderMain_result3.innerHTML = val3;
        }
        else if (counter == 4) {
            var val4 = $("#ContentPlaceHolderMain_select_2").attr('value');
            ContentPlaceHolderMain_result4.innerHTML = val4;
        }
        else if (counter == 5) {
            var val5 = $("#ContentPlaceHolderMain_select_3").attr('value');
            ContentPlaceHolderMain_result5.innerHTML = val5;
        }
    })
})
$(document).ready(function () {
    $("#quxiao").click(function () {
        ContentPlaceHolderMain_result1.innerHTML = "";
        ContentPlaceHolderMain_result2.innerHTML = "";
        ContentPlaceHolderMain_result3.innerHTML = "";
        ContentPlaceHolderMain_result4.innerHTML = "";
        ContentPlaceHolderMain_result5.innerHTML = "";
    })
})
$(document).ready(function () {
    $("#submit").click(function () {
        if(counter == 1){
            var val1 = $("#ContentPlaceHolderMain_select_1").attr('value');
            var value1 = $("#ContentPlaceHolderMain_result1").html();
            if (value1 != val1) {
                alert("选错，请重新选择")
                return;
            }
            else{
                $("#yzc").fadeIn();
                $("#ContentPlaceHolderMain_result1").fadeOut();
                ContentPlaceHolderMain_Label1.innerHTML = value1;
            }
            counter++;
        }
        else if(counter ==2)
        {
            var val2 = $("#ContentPlaceHolderMain_select_0").attr('value');
            var value2 = $("#ContentPlaceHolderMain_result2").html();
            if (value2 != val2) {
                alert("选错，请重新选择")
                return;
            }else{
                $("#yzd").fadeIn();
                $("#ContentPlaceHolderMain_result2").fadeOut();
                ContentPlaceHolderMain_Label2.innerHTML = value2;
            }
            counter++;
        }
        else if(counter == 3){
            var val3 = $("#ContentPlaceHolderMain_select_4").attr('value');
            var value3 = $("#ContentPlaceHolderMain_result3").html();
            if (value3 != val3) {
                alert("选错，请重新选择")
                return;
            }
            else{
                $("#yze").fadeIn();
                $("#ContentPlaceHolderMain_result3").fadeOut();
                ContentPlaceHolderMain_Label3.innerHTML = value3;
            }
            counter++;
        }
        else if(counter==4){
            var val4 = $("#ContentPlaceHolderMain_select_2").attr('value');
            var value4 = $("#ContentPlaceHolderMain_result4").html();
            if (value4 != val4) {
                alert("选错，请重新选择")
                return;
            } else {
                $("#wzl2").fadeIn();
                $("#ContentPlaceHolderMain_result4").fadeOut();
                ContentPlaceHolderMain_Label4.innerHTML = value4;
            }
            counter++;
        }
        else if(counter ==5){
            var val5 = $("#ContentPlaceHolderMain_select_3").attr('value');
            var value5 = $("#ContentPlaceHolderMain_result5").html();
            if (value5 != val5) {
                alert("选错，请重新选择")
                return;
            }
            else {
                $("#ContentPlaceHolderMain_result5").fadeOut();
                $("#complete").fadeIn();
                ContentPlaceHolderMain_Label5.innerHTML = value5;
            }
        }
    })
})
$(document).ready(function () {
    $("#task1").click(function () {
        $("#ContentPlaceHolderMain_result1").fadeIn();
        $.layer({
            type: 1,   //0-4的选择,
            title: false,
            border: [0],
            shade: [1],
            closeBtn: [0],
            shadeClose: true,
            area: ['0px', '0px'],
            page: {
                html: '<div id="box"><h3 class="title">'+t2+'</h3></div>' //此处放了防止html被解析，用了\转义，实际使用时可去掉(已改)
            }
        });
    })
})
$(document).ready(function () {
    $("#task2").click(function () {
        $("#ContentPlaceHolderMain_result2").fadeIn();
        $.layer({
            type: 1,   //0-4的选择,
            title: false,
            border: [0],
            shade: [1],
            closeBtn: [0],
            shadeClose: true,
            area: ['0px', '0px'],
            page: {
                html: '<div id="box"><h3 class="title">'+t3+'</h3></div>' //此处放了防止html被解析，用了\转义，实际使用时可去掉(已改)
            }
        });
    })
})
$(document).ready(function () {
    $("#task3").click(function () {
        $("#ContentPlaceHolderMain_result3").fadeIn();
        $.layer({
            type: 1,   //0-4的选择,
            title: false,
            border: [0],
            shade: [1],
            closeBtn: [0],
            shadeClose: true,
            area: ['0px', '0px'],
            page: {
                html: '<div id="box"><h3 class="title">' + t4 + '</h3></div>' //此处放了防止html被解析，用了\转义，实际使用时可去掉(已改)
            }
        });
    })
})
$(document).ready(function () {
    $("#task4").click(function () {
        $("#ContentPlaceHolderMain_result4").fadeIn();
        $.layer({
            type: 1,   //0-4的选择,
            title: false,
            border: [0],
            shade: [1],
            closeBtn: [0],
            shadeClose: true,
            area: ['0px', '0px'],
            page: {
                html: '<div id="box"><h3 class="title">' + t5 + '</h3></div>' //此处放了防止html被解析，用了\转义，实际使用时可去掉(已改)
            }
        });
    })
})
$(document).ready(function () {
    $("#task5").click(function () {
        $("#ContentPlaceHolderMain_result5").fadeIn();
        $.layer({
            type: 1,   //0-4的选择,
            title: false,
            border: [0],
            shade: [1],
            closeBtn: [0],
            shadeClose: true,
            area: ['0px', '0px'],
            page: {
                html: '<div id="box"><h3 class="title">'+t6+'</h3></div>' //此处放了防止html被解析，用了\转义，实际使用时可去掉(已改)
            }
        });
    })
})
//========================================================================

function show($item) {
    document.getElementById("content").innerHTML = $item.value;
}

$(document).ready(function () {               //小气泡
    $('#xing').on('click', function () {
        $("#yza").fadeIn();
        layer.tips(t1, this, {
            style: ['background-color:#0FA6D8; color:#fff', '#0FA6D8'], time: 3,
            maxWidth: 150
        });
    });
});



//============================用于退拽div的代码=============================================
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
        var oTitle = oBox.getElementsByTagName("h3")[0];
        var oDrag = new Drag(oBox, { handle: oTitle, limit: false });
    });
});
   //====================================================

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
        var element = "<div id='finish' class='alert alert-success'>"+
        "<button class='close' data-dismiss='alert' type='button'>×</button>"+
        "<h2>您总共<span id='time3'></span></h2><a class='btn btn-success' href='study3.aspx?time="+ i +"'>进入下一关</a>"+
        "&nbsp<a class='btn' href=javascript:void(location.reload())'>不服！再来一次</a></div>";
        $("#complete").after(element);
        time3.innerHTML = "用时" + Math.floor(i / 3600) + "小时" + Math.floor(i / 60) + "分" + i % 60 + "秒";
        $("#finish").fadeIn();
    })
});
