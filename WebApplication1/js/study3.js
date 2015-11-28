

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
        "<h2>您总共<span id='time3'></span></h2><a class='btn btn-success' href='study4-1.aspx?time=" + i + "'>进入下一关</a>" +
        "&nbsp<a class='btn' href=javascript:void(location.reload())'>不服！再来一次</a></div>";
        $("#complete").after(element);
        time3.innerHTML = "用时" + Math.floor(i / 3600) + "小时" + Math.floor(i / 60) + "分" + i % 60 + "秒";
        $("#finish").fadeIn();
    })
});

//=====================================

        $(document).ready(function(){
            $(".task").click(function(){
                $.layer({
                    type: 1,   //0-4的选择,
                    title: false,
                    border: [0],
                    shade: [1],
                    closeBtn: [0],
                    shadeClose: true,
                    area: ['0px', '0px'],
                    page: {
                        html: '<div id="box"><h5 class = "title">' + t2 + '</h5> </div>' //此处放了防止html被解析，用了\转义，实际使用时可去掉(已改)
                    }
                });
            })
            $(".task2").click(function(){
                $.layer({
                    type: 1,   //0-4的选择,
                    title: false,
                    border: [0],
                    shade: [1],
                    closeBtn: [0],
                    shadeClose: true,
                    area: ['0px', '0px'],
                    page: {
                        html: '<div id="box"><h5 class = "title">'+t1+'</h5> </div>' //此处放了防止html被解析，用了\转义，实际使用时可去掉(已改)
                    }
                });
            })
              $(".task3").click(function(){
                $.layer({
                    type: 1,   //0-4的选择,
                    title: false,
                    border: [0],
                    shade: [1],
                    closeBtn: [0],
                    shadeClose: true,
                    area: ['0px', '0px'],
                    page: {
                        html: '<div id="box"><h5 class = "title">'+t3+'</h5> </div>' //此处放了防止html被解析，用了\转义，实际使用时可去掉(已改)
                    }
                });
              })
              $(".task4").click(function () {
                  $.layer({
                      type: 1,   //0-4的选择,
                      title: false,
                      border: [0],
                      shade: [1],
                      closeBtn: [0],
                      shadeClose: true,
                      area: ['0px', '0px'],
                      page: {
                          html: '<div id="box"><h5 class = "title">' + t3 + '</h5> </div>' //此处放了防止html被解析，用了\转义，实际使用时可去掉(已改)
                      }
                  });
              })
        })
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
 //当点击name为XXX的radio时把name为YYY对应选中的文本传给id为ZZZ的标签；
//$('input:radio[name="XXX"]').click(function () { transferValue("YYY", "ZZZ") });
 $(document).ready(counter = 1);      //页面加载给计数器设为1.其中botton1和botton2也可以控制counter
 $(document).ready(function(){
     $('input:radio[name="ctl00$ContentPlaceHolderMain$sop"]').click(function () {
         if (counter == 1) { transferValue("ctl00$ContentPlaceHolderMain$sop", "ContentPlaceHolderMain_result") }
         else if(counter == 4){ transferValue("ctl00$ContentPlaceHolderMain$sop", "ContentPlaceHolderMain_result2") }
         else if(counter == 7){ transferValue("ctl00$ContentPlaceHolderMain$sop", "ContentPlaceHolderMain_result2_1") }
         else if(counter == 10){ transferValue("ctl00$ContentPlaceHolderMain$sop", "ContentPlaceHolderMain_result3") }
         else if(counter == 13){ transferValue("ctl00$ContentPlaceHolderMain$sop", "gc1") }
         else{transferValue("ctl00$ContentPlaceHolderMain$sop", "gc2")}
     });

     $('input:radio[name="ctl00$ContentPlaceHolderMain$dx"]').click(function () {
         if (counter == 2) { transferValue("ctl00$ContentPlaceHolderMain$dx", "ContentPlaceHolderMain_resultdx") }
         else if (counter == 3) { transferValue("ctl00$ContentPlaceHolderMain$dx", "ContentPlaceHolderMain_resultdxa") }
         else if (counter == 5) { transferValue("ctl00$ContentPlaceHolderMain$dx", "ContentPlaceHolderMain_resultdx2") }
         else if (counter == 6) { transferValue("ctl00$ContentPlaceHolderMain$dx", "ContentPlaceHolderMain_rdxa2") }
         else if (counter == 8) { transferValue("ctl00$ContentPlaceHolderMain$dx", "ContentPlaceHolderMain_rdx2_1") }
         else if (counter == 9) { transferValue("ctl00$ContentPlaceHolderMain$dx", "ContentPlaceHolderMain_rdxa2_1") }
         else if (counter == 11) { transferValue("ctl00$ContentPlaceHolderMain$dx", "ContentPlaceHolderMain_rdx3") }
         else if (counter == 12) { transferValue("ctl00$ContentPlaceHolderMain$dx", "ContentPlaceHolderMain_rdxa3") }
     });
     $('input:radio[name="ctl00$ContentPlaceHolderMain$tj"]').click(function () {
         if (counter == 2) { transferValue("ctl00$ContentPlaceHolderMain$tj", "ContentPlaceHolderMain_resulttj") }
         else if (counter == 3) { transferValue("ctl00$ContentPlaceHolderMain$tj", "ContentPlaceHolderMain_resulttja") }
         else if (counter == 5) { transferValue("ctl00$ContentPlaceHolderMain$tj", "ContentPlaceHolderMain_resulttj2") }
         else if (counter == 6) { transferValue("ctl00$ContentPlaceHolderMain$tj", "ContentPlaceHolderMain_rtja2") }
         else if (counter == 8) { transferValue("ctl00$ContentPlaceHolderMain$tj", "ContentPlaceHolderMain_rtj2_1") }
         else if (counter == 9) { transferValue("ctl00$ContentPlaceHolderMain$tj", "ContentPlaceHolderMain_rtja2_1") }
         else if (counter == 11) { transferValue("ctl00$ContentPlaceHolderMain$tj", "ContentPlaceHolderMain_rtj3") }
         else if (counter == 12) { transferValue("ctl00$ContentPlaceHolderMain$tj", "ContentPlaceHolderMain_rtja3") }
     });
     $('input:radio[name="ctl00$ContentPlaceHolderMain$fx"]').click(function () {
         if (counter == 2) { transferValue("ctl00$ContentPlaceHolderMain$fx", "ContentPlaceHolderMain_resultfx") }
         else if (counter == 3) { transferValue("ctl00$ContentPlaceHolderMain$fx", "ContentPlaceHolderMain_resultfxa") }
         else if (counter == 5) { transferValue("ctl00$ContentPlaceHolderMain$fx", "ContentPlaceHolderMain_resultfx2") }
         else if (counter == 6) { transferValue("ctl00$ContentPlaceHolderMain$fx", "ContentPlaceHolderMain_rfxa2") }
         else if (counter == 7) { transferValue("ctl00$ContentPlaceHolderMain$fx", "ContentPlaceHolderMain_rfx2_1") }
         else if (counter == 8) { transferValue("ctl00$ContentPlaceHolderMain$fx", "ContentPlaceHolderMain_rfxa2_1") }
         else if (counter == 11) { transferValue("ctl00$ContentPlaceHolderMain$fx", "ContentPlaceHolderMain_rfx3") }
         else if (counter == 12) { transferValue("ctl00$ContentPlaceHolderMain$fx", "ContentPlaceHolderMain_rfxa3") }
     });
     $('input:radio[name="ctl00$ContentPlaceHolderMain$yj"]').click(function () {
         if (counter == 2) { transferValue("ctl00$ContentPlaceHolderMain$yj", "ContentPlaceHolderMain_resultyj") }
         else if (counter == 3) { transferValue("ctl00$ContentPlaceHolderMain$yj", "ContentPlaceHolderMain_resultyja") }
         else if (counter == 5) { transferValue("ctl00$ContentPlaceHolderMain$yj", "ContentPlaceHolderMain_resultyj2") }
         else if (counter == 6) { transferValue("ctl00$ContentPlaceHolderMain$yj", "ContentPlaceHolderMain_ryja2") }
         else if (counter == 8) { transferValue("ctl00$ContentPlaceHolderMain$yj", "ContentPlaceHolderMain_ryj2_1") }
         else if (counter == 9) { transferValue("ctl00$ContentPlaceHolderMain$yj", "ContentPlaceHolderMain_ryja2_1") }
         else if (counter == 11) { transferValue("ctl00$ContentPlaceHolderMain$yj", "ContentPlaceHolderMain_ryj3") }
         else if (counter == 12) { transferValue("ctl00$ContentPlaceHolderMain$yj", "ContentPlaceHolderMain_ryja3") }
     });
 });
 $(document).ready(function () {
     $("#Button").click(function () {
         if(counter == 1){
            
             var valv5 = $("#ContentPlaceHolderMain_sop_0").attr('value');
        
             ContentPlaceHolderMain_result.innerHTML = valv5;
         }
         else if (counter == 2) {
             var valv1 = $("#ContentPlaceHolderMain_dx_1").attr('value');
             var valv2 = $("#ContentPlaceHolderMain_tj_1").attr('value');
             var valv3 = $("#ContentPlaceHolderMain_fx_2").attr('value');
             var valv4 = $("#ContentPlaceHolderMain_yj_2").attr('value');
             ContentPlaceHolderMain_resultdx.innerHTML = valv1;
             ContentPlaceHolderMain_resulttj.innerHTML = valv2;
             ContentPlaceHolderMain_resultfx.innerHTML = valv3;
             ContentPlaceHolderMain_resultyj.innerHTML = valv4;
           
         }
         else if (counter == 3) {
             var vala1 = $("#ContentPlaceHolderMain_dx_0").attr('value');
             var vala2 = $("#ContentPlaceHolderMain_tj_4").attr('value');
             var vala3 = $("#ContentPlaceHolderMain_fx_1").attr('value');
             var vala4 = $("#ContentPlaceHolderMain_yj_3").attr('value');
             ContentPlaceHolderMain_resultdxa.innerHTML = vala1;
             ContentPlaceHolderMain_resulttja.innerHTML = vala2;
             ContentPlaceHolderMain_resultfxa.innerHTML = vala3;
             ContentPlaceHolderMain_resultyja.innerHTML = vala4;
           
         }
         else if (counter == 4) {
             var val2_5 = $("#ContentPlaceHolderMain_sop_1").attr('value');
             ContentPlaceHolderMain_result2.innerHTML = val2_5;
            
         }
         else if (counter == 5) {
             var val2_1 = $("#ContentPlaceHolderMain_dx_4").attr('value');
             var val2_2 = $("#ContentPlaceHolderMain_tj_4").attr('value');
             var val2_3 = $("#ContentPlaceHolderMain_fx_1").attr('value');
             var val2_4 = $("#ContentPlaceHolderMain_yj_4").attr('value');

             ContentPlaceHolderMain_resultdx2.innerHTML = val2_1;
             ContentPlaceHolderMain_resulttj2.innerHTML = val2_2;
             ContentPlaceHolderMain_resultfx2.innerHTML = val2_3;
             ContentPlaceHolderMain_resultyj2.innerHTML = val2_4;

           
            
         }
         else if (counter == 6) {
             var val2_1a = $("#ContentPlaceHolderMain_dx_0").attr('value');
             var val2_2a = $("#ContentPlaceHolderMain_tj_1").attr('value');
             var val2_3a = $("#ContentPlaceHolderMain_fx_1").attr('value');
             var val2_4a = $("#ContentPlaceHolderMain_yj_4").attr('value');
             ContentPlaceHolderMain_rdxa2.innerHTML = val2_1a;
             ContentPlaceHolderMain_rtja2.innerHTML = val2_2a;
             ContentPlaceHolderMain_rfxa2.innerHTML = val2_3a;
             ContentPlaceHolderMain_ryja2.innerHTML = val2_4a;
           
         }
         else if (counter == 7) {
             var val25 = $("#ContentPlaceHolderMain_sop_2").attr('value');
             ContentPlaceHolderMain_result2_1.innerHTML = val25;
         
         }
         else if (counter == 8) {
             var val21 = $("#ContentPlaceHolderMain_dx_2").attr('value');
             var val22 = $("#ContentPlaceHolderMain_tj_4").attr('value');
             var val23 = $("#ContentPlaceHolderMain_fx_1").attr('value');
             var val24 = $("#ContentPlaceHolderMain_yj_1").attr('value');

             ContentPlaceHolderMain_rdx2_1.innerHTML = val21;
             ContentPlaceHolderMain_rtj2_1.innerHTML = val22;
             ContentPlaceHolderMain_rfx2_1.innerHTML = val23;
             ContentPlaceHolderMain_ryj2_1.innerHTML = val24;
        
         }
         else if (counter == 9) {
             var val21a = $("#ContentPlaceHolderMain_dx_3").attr('value');
             var val22a = $("#ContentPlaceHolderMain_tj_2").attr('value');
             var val23a = $("#ContentPlaceHolderMain_fx_0").attr('value');
             var val24a = $("#ContentPlaceHolderMain_yj_5").attr('value');
             ContentPlaceHolderMain_rdxa2_1.innerHTML = val21a;
             ContentPlaceHolderMain_rtja2_1.innerHTML = val22a;
             ContentPlaceHolderMain_rfxa2_1.innerHTML = val23a;
             ContentPlaceHolderMain_ryja2_1.innerHTML = val24a;
         }
         else if(counter == 10){
             var val35 = $("#ContentPlaceHolderMain_sop_3").attr('value');
             ContentPlaceHolderMain_result3.innerHTML = val35;
         }
         else if(counter == 11){
             var val31 = $("#ContentPlaceHolderMain_dx_1").attr('value');
             var val32 = $("#ContentPlaceHolderMain_tj_8").attr('value');
             var val33 = $("#ContentPlaceHolderMain_fx_2").attr('value');
             var val34 = $("#ContentPlaceHolderMain_yj_2").attr('value');
           
             ContentPlaceHolderMain_rdx3.innerHTML = val31;
             ContentPlaceHolderMain_rtj3.innerHTML = val32;
             ContentPlaceHolderMain_rfx3.innerHTML = val33;
             ContentPlaceHolderMain_ryj3.innerHTML = val34;
         
         }
         else if(counter == 12){
             var val31a = $("#ContentPlaceHolderMain_dx_3").attr('value');
             var val32a = $("#ContentPlaceHolderMain_tj_3").attr('value');
             var val33a = $("#ContentPlaceHolderMain_fx_0").attr('value');
             var val34a = $("#ContentPlaceHolderMain_yj_6").attr('value');
             ContentPlaceHolderMain_rdxa3.innerHTML = val31a;
             ContentPlaceHolderMain_rtja3.innerHTML = val32a;
             ContentPlaceHolderMain_rfxa3.innerHTML = val33a;
             ContentPlaceHolderMain_ryja3.innerHTML = val34a;
         }
         else if(counter == 13){
             var v9 = $("#ContentPlaceHolderMain_sop_4").attr('value');
             gc1.innerHTML = v9;
         }
         else {
             var v10 = $("#ContentPlaceHolderMain_sop_5").attr('value');
             gc2.innerHTML = v10;
         }
             })
 })
     $(document).ready(function () {
         $("#Button2").click(function () {
           
                 ContentPlaceHolderMain_resultdx.innerHTML = "";
                 ContentPlaceHolderMain_resulttj.innerHTML = "";
                 ContentPlaceHolderMain_resultfx.innerHTML = "";
                 ContentPlaceHolderMain_resultyj.innerHTML = "";
                 ContentPlaceHolderMain_result.innerHTML = "";
             
            
                 ContentPlaceHolderMain_resultdxa.innerHTML = "";
                 ContentPlaceHolderMain_resulttja.innerHTML = "";
                 ContentPlaceHolderMain_resultfxa.innerHTML = "";
                 ContentPlaceHolderMain_resultyja.innerHTML = "";
 
                 ContentPlaceHolderMain_resultdx2.innerHTML = "";
                 ContentPlaceHolderMain_resulttj2.innerHTML = "";
                 ContentPlaceHolderMain_resultfx2.innerHTML = "";
                 ContentPlaceHolderMain_resultyj2.innerHTML = "";
                 ContentPlaceHolderMain_result2.innerHTML = "";
            
                 ContentPlaceHolderMain_rdxa2.innerHTML = "";
                 ContentPlaceHolderMain_rtja2.innerHTML = "";
                 ContentPlaceHolderMain_rfxa2.innerHTML = "";
                 ContentPlaceHolderMain_ryja2.innerHTML = "";
            
                 ContentPlaceHolderMain_rdx2_1.innerHTML = "";
                 ContentPlaceHolderMain_rtj2_1.innerHTML = "";
                 ContentPlaceHolderMain_rfx2_1.innerHTML = "";
                 ContentPlaceHolderMain_ryj2_1.innerHTML = "";
                 ContentPlaceHolderMain_result2_1.innerHTML = "";
          
                 ContentPlaceHolderMain_rdxa2_1.innerHTML = "";
                 ContentPlaceHolderMain_rtja2_1.innerHTML = "";
                 ContentPlaceHolderMain_rfxa2_1.innerHTML = "";
                 ContentPlaceHolderMain_ryja2_1.innerHTML = "";
        
                 ContentPlaceHolderMain_rdx3.innerHTML = "";
                 ContentPlaceHolderMain_rtj3.innerHTML = "";
                 ContentPlaceHolderMain_rfx3.innerHTML = "";
                 ContentPlaceHolderMain_ryj3.innerHTML = "";
                 ContentPlaceHolderMain_result3.innerHTML = "";
          
                 ContentPlaceHolderMain_rdxa3.innerHTML = "";
                 ContentPlaceHolderMain_rtja3.innerHTML = "";
                 ContentPlaceHolderMain_rfxa3.innerHTML = "";
                 ContentPlaceHolderMain_ryja3.innerHTML = "";
             
         })
     })
     $(document).ready(function () {             
         $("#yes").click(function () {
             if (counter == 1){
                 var valuev5 = $("#ContentPlaceHolderMain_result").html();
                 var valv5 = $("#ContentPlaceHolderMain_sop_0").attr('value');
                 if (valuev5 != valv5) {
                     alert("状态特征选错，请重新选择")
                     return;

                 }
                 else {
                     $("#task1_1").fadeIn();
                     $("#z1").fadeIn();
                     counter++;
                 }
             }
               else  if (counter == 2) {
                     var valuev1 = $("#ContentPlaceHolderMain_resultdx").html();
                     var valuev2 = $("#ContentPlaceHolderMain_resulttj").html();
                     var valuev3 = $("#ContentPlaceHolderMain_resultfx").html();
                     var valuev4 = $("#ContentPlaceHolderMain_resultyj").html();

                     var valv1 = $("#ContentPlaceHolderMain_dx_1").attr('value');
                     var valv2 = $("#ContentPlaceHolderMain_tj_1").attr('value');
                     var valv3 = $("#ContentPlaceHolderMain_fx_2").attr('value');
                     var valv4 = $("#ContentPlaceHolderMain_yj_2").attr('value');

                     if (valuev1 != valv1) {
                         alert("速度大小选错，请重新选择")
                         return;
                     }
                     else if (valuev2 != valv2) {
                         alert("速度依据选错，请重新选择")
                         return;
                     }
                     else if (valuev3 != valv3) {
                         alert("速度方向选错，请重新选择")
                         return;
                     }
                     else if (valuev4 != valv4) {
                         alert("方向依据选错，请重新选择")
                         return;
                     }
                     else {
                         ContentPlaceHolderMain_m2dx1.innerHTML = valuev1;
                         ContentPlaceHolderMain_m2tj1.innerHTML = valuev2;
                         ContentPlaceHolderMain_m2fx1.innerHTML = valuev3;
                         ContentPlaceHolderMain_m2yj1.innerHTML = valuev4;
                         $("#middle3xianshi").fadeOut();
                         $("#a1").fadeIn();
                         $("#z1a").fadeIn();
                         $("#heart1").fadeIn();

                         counter++;
                     }
                 }
                 else if (counter == 3) {
                     var valuea1 = $("#ContentPlaceHolderMain_resultdxa").html();
                     var valuea2 = $("#ContentPlaceHolderMain_resulttja").html();
                     var valuea3 = $("#ContentPlaceHolderMain_resultfxa").html();
                     var valuea4 = $("#ContentPlaceHolderMain_resultyja").html();
                     var vala1 = $("#ContentPlaceHolderMain_dx_0").attr('value');
                     var vala2 = $("#ContentPlaceHolderMain_tj_4").attr('value');
                     var vala3 = $("#ContentPlaceHolderMain_fx_1").attr('value');
                     var vala4 = $("#ContentPlaceHolderMain_yj_3").attr('value');
                     if (valuea1 != vala1) {
                         alert("加速度大小选错，请重新选择")
                         return;
                     }
                     else if (valuea2 != vala2) {
                         alert("加速度依据选错，请重新选择")
                         return;
                     }
                     else if (valuea3 != vala3) {
                         alert("加速度方向选错，请重新选择")
                         return;
                     }
                     else if (valuea4 != vala4) {
                         alert("加速度方向依据选错，请重新选择")
                         return;
                     } else {
                         ContentPlaceHolderMain_m2dxa.innerHTML = vala1;
                         ContentPlaceHolderMain_m2tja.innerHTML = vala2;
                         ContentPlaceHolderMain_m2fxa.innerHTML = vala3;
                         ContentPlaceHolderMain_m2yja.innerHTML = vala4;
                         $("#change").fadeOut();
                         $("#task2").fadeIn();
                         $("#heart1").fadeOut();
                         $("#change2").fadeIn();
                     }
                     counter++;

                 }
                 else if(counter == 4){
                     var value2_5 = $("#ContentPlaceHolderMain_result2").html();
                     var val2_5 = $("#ContentPlaceHolderMain_sop_1").attr('value');
                     if (value2_5 != val2_5) {
                         alert("状态特征选错，请重新选择")
                         return;
                     }
                     else{
                         $("#z2v").fadeIn();
                        
                         $("#st2b").fadeIn();
                         $("#middle3xianshi2").fadeIn();
                         $("#z2v").fadeIn();
                         
                         $("#state2b").fadeIn();
                        
                         $("#heart2").fadeIn();
                         counter++;
                     }
                 }
                 else if (counter == 5) {
                     var value2_1 = $("#ContentPlaceHolderMain_resultdx2").html();
                     var value2_2 = $("#ContentPlaceHolderMain_resulttj2").html();
                     var value2_3 = $("#ContentPlaceHolderMain_resultfx2").html();
                     var value2_4 = $("#ContentPlaceHolderMain_resultyj2").html();
                    
                     var val2_1 = $("#ContentPlaceHolderMain_dx_4").attr('value');
                     var val2_2 = $("#ContentPlaceHolderMain_tj_4").attr('value');
                     var val2_3 = $("#ContentPlaceHolderMain_fx_1").attr('value');
                     var val2_4 = $("#ContentPlaceHolderMain_yj_4").attr('value');
                    
                     if (value2_1 != val2_1) {
                         alert("速度大小选错，请重新选择")
                         return;
                     } else if (value2_2 != val2_2) {
                         alert("速度依据选错，请重新选择")
                         return;
                     } else if (value2_3 != val2_3) {
                         alert("速度方向选错，请重新选择")
                         return;
                     } else if (value2_4 != val2_4) {
                         alert("方向依据选错，请重新选择")
                         return;
                     } 
                  else {
                     ContentPlaceHolderMain_m2dx2.innerHTML = value2_1;
                     ContentPlaceHolderMain_m2tj2.innerHTML = value2_2;
                     ContentPlaceHolderMain_m2fx2.innerHTML = value2_3;
                     ContentPlaceHolderMain_m2yj2.innerHTML = value2_4;
                     $("#middle3xianshi2").fadeOut();
                     $("#a2").fadeIn();
                     $("#z2a").fadeIn();
                     $("#heart3").fadeIn();

                 }
                     counter++;
                 }
                 else if (counter == 6) {
                     var value2_1a = $("#ContentPlaceHolderMain_rdxa2").html();
                     var value2_2a = $("#ContentPlaceHolderMain_rtja2").html();
                     var value2_3a = $("#ContentPlaceHolderMain_rfxa2").html();
                     var value2_4a = $("#ContentPlaceHolderMain_ryja2").html();
                     var val2_1a = $("#ContentPlaceHolderMain_dx_0").attr('value');
                     var val2_2a = $("#ContentPlaceHolderMain_tj_1").attr('value');
                     var val2_3a = $("#ContentPlaceHolderMain_fx_1").attr('value');
                     var val2_4a = $("#ContentPlaceHolderMain_yj_4").attr('value');
                     if (value2_1a != val2_1a) {
                         alert("加速度大小选错，请重新选择")
                         return;
                     } else if (value2_2a != val2_2a) {
                         alert("加速度依据选错，请重新选择")
                         return;
                     } else if (value2_3a != val2_3a) {
                         alert("加速度方向选错，请重新选择")
                         return;
                     } else if (value2_4a != val2_4a) {
                         alert("加速度方向依据选错，请重新选择")
                         return;
                     } else {
                         ContentPlaceHolderMain_m2dxa2.innerHTML = value2_1a;
                         ContentPlaceHolderMain_m2tja2.innerHTML = value2_2a;
                         ContentPlaceHolderMain_m2fxa2.innerHTML = value2_3a;
                         ContentPlaceHolderMain_m2yja2.innerHTML = value2_4a;
                         $("#change2").fadeOut();
                         $("#st2").fadeIn();
                        
                         $("#change2_1").fadeIn();
                         $("#middle3xianshi2_1").fadeIn();
                         $("#heart3").fadeOut();
                         $("#heart4").fadeIn();
                         $("#task3").fadeIn();
                     }
                     counter++;
                     //状态II
                 } else if (counter == 7) {
                    
                     var value25 = $("#ContentPlaceHolderMain_result2_1").html();
                    
                     var val25 = $("#ContentPlaceHolderMain_sop_2").attr('value');
                   
                       if (value25 != val25) {
                         alert("状态特征选错，请重新选择")
                         return;
                     } else {
                        
                         $("#z2_1v").fadeIn();
                         $("#middle3xianshi2_1").fadeOut();
                         $("#a2_1").fadeIn();
                         $("#heart5").fadeIn();

                     }
                     counter++;
                 }
                 else if (counter == 8) {
                     var value21 = $("#ContentPlaceHolderMain_rdx2_1").html();
                     var value22 = $("#ContentPlaceHolderMain_rtj2_1").html();
                     var value23 = $("#ContentPlaceHolderMain_rfx2_1").html();
                     var value24 = $("#ContentPlaceHolderMain_ryj2_1").html();
                     var val21 = $("#ContentPlaceHolderMain_dx_2").attr('value');
                     var val22 = $("#ContentPlaceHolderMain_tj_4").attr('value');
                     var val23 = $("#ContentPlaceHolderMain_fx_1").attr('value');
                     var val24 = $("#ContentPlaceHolderMain_yj_1").attr('value');
                     if (value21 != val21) {
                         alert("速度大小选错，请重新选择")
                         return;
                     } else if (value22 != val22) {
                         alert("速度依据选错，请重新选择")
                         return;
                     } else if (value23 != val23) {
                         alert("速度方向选错，请重新选择")
                         return;
                     } else if (value24 != val24) {
                         alert("方向依据选错，请重新选择")
                         return;
                     } else {
                         ContentPlaceHolderMain_m2dx2_1.innerHTML = value21;
                         ContentPlaceHolderMain_m2tj2_1.innerHTML = value22;
                         ContentPlaceHolderMain_m2fx2_1.innerHTML = value23;
                         ContentPlaceHolderMain_m2yj2_1.innerHTML = value24;
                         $("#z2_1a").fadeIn();
                         counter++;
                     }
                 }
                 else if (counter == 9) {
                     var value21a = $("#ContentPlaceHolderMain_rdxa2_1").html();
                     var value22a = $("#ContentPlaceHolderMain_rtja2_1").html();
                     var value23a = $("#ContentPlaceHolderMain_rfxa2_1").html();
                     var value24a = $("#ContentPlaceHolderMain_ryja2_1").html();
                     var val21a = $("#ContentPlaceHolderMain_dx_3").attr('value');
                     var val22a = $("#ContentPlaceHolderMain_tj_2").attr('value');
                     var val23a = $("#ContentPlaceHolderMain_fx_0").attr('value');
                     var val24a = $("#ContentPlaceHolderMain_yj_5").attr('value');
                     if (value21a != val21a) {
                         alert("加速度大小选错，请重新选择")
                         return;
                     } else if (value22a != val22a) {
                         alert("加速度依据选错，请重新选择")
                         return;
                     } else if (value23a != val23a) {
                         alert("加速度方向选错，请重新选择")
                         return;
                     } else if (value24a != val24a) {
                         alert("方向依据选错，请重新选择")
                         return;
                     } else {
                         ContentPlaceHolderMain_m2dxa2_1.innerHTML = value21a;
                         ContentPlaceHolderMain_m2tja2_1.innerHTML = value22a;
                         ContentPlaceHolderMain_m2fxa2_1.innerHTML = value23a;
                         ContentPlaceHolderMain_m2yja2_1.innerHTML = value24a;
                         $("#change2_1").fadeOut();
                         //状态III
                         $("#st3").fadeIn();
                         $("#change3").fadeIn();
                         
                       
                         $("#state3").fadeIn();
                         $("#heart5").fadeOut();
                         $("#heart6").fadeIn();
                         $("#")
                     }
                     counter++
                 }
                 else if (counter == 10) {
                     var value35 = $("#ContentPlaceHolderMain_result3").html();
                     var val35 = $("#ContentPlaceHolderMain_sop_3").attr('value');
                  if (value35 != val35) {
                         alert("状态特征选错，请重新选择")
                         return;
                         $("#z3v").fadeIn();
                         $("#middle3xianshi3").fadeIn();
                         counter++;
                     }
                 }
                 else if (counter == 11) {
                     var value31 = $("#ContentPlaceHolderMain_rdx3").html();
                     var value32 = $("#ContentPlaceHolderMain_rtj3").html();
                     var value33 = $("#ContentPlaceHolderMain_rfx3").html();
                     var value34 = $("#ContentPlaceHolderMain_ryj3").html();
                   
                     var val31 = $("#ContentPlaceHolderMain_dx_1").attr('value');
                     var val32 = $("#ContentPlaceHolderMain_tj_8").attr('value');
                     var val33 = $("#ContentPlaceHolderMain_fx_2").attr('value');
                     var val34 = $("#ContentPlaceHolderMain_yj_2").attr('value');
                    
                     if (value31 != val31) {
                         alert("速度大小选错，请重新选择")
                         return;
                     } else if (value32 != val32) {
                         alert("速度依据选错，请重新选择")
                         return;
                     } else if (value33 != val33) {
                         alert("速度方向选错，请重新选择")
                         return;
                     } else if (value34 != val34) {
                         alert("方向依据选错，请重新选择")
                         return;
                     }  else {
                         ContentPlaceHolderMain_m2dx3.innerHTML = val31;
                         ContentPlaceHolderMain_m3tj3.innerHTML = val32;
                         ContentPlaceHolderMain_m2fx3.innerHTML = val33;
                         ContentPlaceHolderMain_m2yj3.innerHTML = val34;
                         $("#middle3xianshi3").fadeOut();
                         $("#a3").fadeIn();
                         $("#z3a").fadeIn();
                         $("#heart7").fadeIn();

                     }
                     counter++;

                 }
                 else if (counter == 12) {
                     var value31a = $("#ContentPlaceHolderMain_rdxa3").html();
                     var value32a = $("#ContentPlaceHolderMain_rtja3").html();
                     var value33a = $("#ContentPlaceHolderMain_rfxa3").html();
                     var value34a = $("#ContentPlaceHolderMain_ryja3").html();
                     var val31a = $("#ContentPlaceHolderMain_dx_3").attr('value');
                     var val32a = $("#ContentPlaceHolderMain_tj_3").attr('value');
                     var val33a = $("#ContentPlaceHolderMain_fx_0").attr('value');
                     var val34a = $("#ContentPlaceHolderMain_yj_6").attr('value');
                     if (value31a != val31a) {
                         alert("加速度大小选错，请重新选择")
                         return;
                     } else if (value32a != val32a) {
                         alert("加速度依据选错，请重新选择")
                         return;
                     } else if (value33a != val33a) {
                         alert("加速度方向选错，请重新选择")
                         return;
                     } else if (value34a != val34a) {
                         alert("方向依据选错，请重新选择")
                         return;
                     } else {
                         ContentPlaceHolderMain_m2dxa3.innerHTML = val31a;
                         ContentPlaceHolderMain_m2tja3.innerHTML = val32a;
                         ContentPlaceHolderMain_m2fxa3.innerHTML = val33a;
                         ContentPlaceHolderMain_m2yja3.innerHTML = val34a;
                         $("#change3").fadeOut();
                         //过程I
                         $("#pro1").fadeIn();
                         $("#process1").fadeIn();
                         $("#guocheng1").fadeIn();
                         $("#heart7").fadeOut();
                         $("#heart8").fadeIn();
                     }
                     counter++;
                 }
                 else if (counter == 13) {
                     var valueg1 = $("#gc1").html();
                     var valg1 = $("#ContentPlaceHolderMain_sop_4").attr('value');
                     if (valueg1 != valg1) {
                         alert("状态选择出错，请重新选择")
                         return;
                     } else {
                         $("#m2gc1").fadeIn();
                         $("#guocheng1").fadeOut();
                         $("#pro2").fadeIn();
                         $("#process2").fadeIn();
                         $("#guocheng2").fadeIn();
                         $("#heart9").fadeIn();
                     }
                     counter++
                 } else {
                     $("#yes").click(function () {
                         var valueg2 = $("#gc2").html();
                         var valg2 = $("#ContentPlaceHolderMain_sop_5").attr('value');
                         if (valueg2 != valg2) {
                             alert("状态选择出错，请重新选择")
                             return;
                         } else {
                             $("#m2gc2").fadeIn();
                             $("#flyout").fadeIn();
                             $("#heart9").fadeOut();
                             $("#heart10").fadeIn();
                         }
                     });
                 }
             
         });
     });
