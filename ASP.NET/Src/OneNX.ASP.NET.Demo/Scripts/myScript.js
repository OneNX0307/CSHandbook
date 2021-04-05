$(document).ready(function () {
    $('#TestBtn').click(function () {
        var userid = $('#UserId').val();
        var username = $('#UserName').val()
        $.ajax({
            type: "POST",
            url: "/Home/DeleteUserById",
            async: true,//默认true异步，同步设置为false
            cache: true,//默认true缓存数据，设置为false不做缓存处理
            data: {
                "id": userid,
                "name": username
            },
            dataType: "json",
            success: function (data) {
                if (data.msg > 0) {
                    window.parent.location.reload(); //刷新父页面
                    setTimeout(function () {
                        var index = parent.layer.getFrameIndex(window.name);
                        parent.layer.close(index);
                    }, 1000);
                }
                else {
                    layer.msg("删除失败！");
                }
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert(XMLHttpRequest.status);
                alert(XMLHttpRequest.readyState);
                alert(textStatus);
            },
            complete: function (XMLHttpRequest, textStatus) {
                alert("Completed!");
            }
        });
    })
})