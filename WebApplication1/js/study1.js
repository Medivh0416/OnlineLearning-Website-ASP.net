
$(document).ready(function () {
    i = 0;
    si = setInterval(function () {
        {
            var h = Math.floor(i / 60);
            $("#time0").html(Math.floor(i / 3600));
            $("#time1").html(h % 60);
            $("#time2").html(i++ % 60);
        };
    }, 1000);
    $("#complete").click(function () {
        clearInterval(si);
        var element = "<div id='finish' class='alert alert-success'>"+
        "<button class='close' data-dismiss='alert' type='button'>×</button>"+
        "<h2>您总共<span id='time3'></span></h2><a class='btn btn-success' href='study2.aspx?time="+ i +"'>进入下一关</a>"+
        "&nbsp<a class='btn' href=javascript:void(location.reload())'>不服！再来一次</a></div>";
        $("#complete").after(element);
        time3.innerHTML = "用时" + Math.floor(i / 3600) + "小时" + Math.floor(i / 60) + "分" + i++ % 60 + "秒";
        $("#finish").fadeIn();
    })
});

