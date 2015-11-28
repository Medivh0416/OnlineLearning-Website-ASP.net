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
        "<h2>您总共<span id='time3'></span></h2><a class='btn btn-success' href='study5.aspx?time=" + i + "'>完成</a>" +
        "&nbsp<a class='btn' href=javascript:void(location.reload())'>不服！再来一次</a></div>";
        $("#complete").after(element);
        time3.innerHTML = "用时" + Math.floor(i / 3600) + "小时" + Math.floor(i / 60) + "分" + i % 60 + "秒";
        $("#finish").fadeIn();
    });
});
$(document).ready(function () {                        //当counter对应时才fedein和fedeout。
    $(".get").click(function () {                  //改成js代码 比较好，适用性更强。以后再说。
        $("#get").fadeIn();
    });
});
$(document).ready(function () {                        //当counter对应时才fedein和fedeout。
    $(".score").click(function () {                  //改成js代码 比较好，适用性更强。以后再说。
        $("#score").fadeIn();
    });
});