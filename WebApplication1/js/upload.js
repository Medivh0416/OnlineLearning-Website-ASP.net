$(document).ready(function () {
    var temp = 0;
    $("#addyjdx").on('click', function () {
        test = "yjdx" + temp;
        $("#addyjdx").before("<input type='text'id=" + test + " class='upLoad'><br />");
        temp++;
    });
    $("#delyjdx").on('click', function () {
        test = "yjdx" + (--temp);
        $("#" + test).next().remove();  //把新建的<br/>一起删掉
        $("#" + test).remove();
    })
});
$(document).ready(function () {
    var temp = 0;
    $("#addyztj").on('click', function () {
        test = "yztj" + temp;
        $("#addyztj").before("<input type='text'id=" + test + " class='upLoad'><br />");
        temp++;
    });
    $("#delyztj").on('click', function () {
        test = "yztj" + (--temp);
        $("#" + test).next().remove();
        $("#" + test).remove();       
    })
});
$(document).ready(function () {
    var temp = 0;
    $("#addyzl").on('click', function () {
        test = "yzl" + temp;
        $("#addyzl").before("<input type='text'id=" + test + " class='upLoad'><br />");
        temp++;
    });
    $("#delyzl").on('click', function () {
        test = "yzl" + (--temp);
        $("#" + test).next().remove();
        $("#" + test).remove();
    })
});
$(document).ready(function () {
    var temp = 0;
    $("#addwzl").on('click', function () {
        test = "wzl" + temp;
        $("#addwzl").before("<input type='text'id=" + test + " class='upLoad'><br />");
        temp++;
    });
    $("#delwzl").on('click', function () {
        test = "wzl" + (--temp);
        $("#" + test).next().remove();
        $("#" + test).remove();
    })
});
$(document).ready(function () {
    var temp = 0;
    $("#addtask").on('click', function () {
        test = "task" + temp;
        $("#addtask").before("<input type='text'id=" + test + " class='upLoad'><br />");
        temp++;
    });
    $("#deltask").on('click', function () {
        test = "task" + (--temp);
        $("#" + test).next().remove();
        $("#" + test).remove();
    })
});
$(document).ready(function () {
    var temp = 0;
    $("#addselection").on('click', function () {
        test = "selection" + temp;
        $("#addselection").before("<input type='text'id=" + test + " class='upLoad'><br />");
        temp++;
    });
    $("#delselection").on('click', function () {
        test = "selection" + (--temp);
        $("#" + test).next().remove();
        $("#" + test).remove();
    })
});
$(document).ready(function () {
    $("#arr").on("click", function () {
        var array = new Array();
        for (var i = 0; i < $(".upLoad").length; i++) {
            array.push($(".upLoad")[i].value);
            console.log($(".upLoad")[i].value);
        }
        console.log(array);
    });
});

/////////////////////////////////表单判断  #ContentPlaceHolderMain_submit
