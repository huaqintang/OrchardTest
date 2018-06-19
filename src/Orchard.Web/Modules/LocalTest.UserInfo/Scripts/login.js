$(function () {
    var token = $(".account input[name='__RequestVerificationToken']").val();
    //登录
    $("input[type='submit']").click(function () {
        var username = $("input[name='username']").val();
        var password = $("input[name='password']").val();
        if (username == "") {
            alert("请输入用户名");
            return;
        }
        if (password == "") {
            alert("请输入密码");
            return;
        }
        $.ajax({
            url: "/LocalTest.UserInfo/UserInfoN/Login",
            type: "POST",
            data: { username: username, psd: password,__RequestVerificationToken:token},
            success: function (resp) {
                if (resp.Success) {
                    alert("登录成功");
                } else {
                    alert("登录失败");
                }
            },
            erro: function () {

            }
        })
    })
})