$(function () {
    //var token = $("input[name='__RequestVerificationToken']").val();
    //注册1： ajax方法
    //$("input[type='submit']").click(function () {
    //    var userName = $("input[name='UserName']").val();
    //    var password = $("input[name='PassWord']").val();
    //    var confirmPsd = $("input[name='confirmPsd']").val();
    //    //判断字段是否全部填写
    //    if (inputValite(userName, password, confirmPsd)) {
    //        $.ajax({
    //            url: "/LocalTest.UserInfo/UserInfoN/Register",
    //            type: "POST",
    //            data: { UserName: userName, PassWord: password},
    //            success: function (resp) {
                    
    //            },
    //            erro: function () {

    //            }
    //        })
    //    }
    //})

    //注册2： input[type='submit'] 提交会刷新页面
    //$("input[type='submit']").click(function () {
    //    var userName = $("input[name='UserName']").val();
    //    var password = $("input[name='PassWord']").val();
    //    var confirmPsd = $("input[name='confirmPsd']").val();
    //    //判断字段是否全部填写
    //    inputValite(userName, password, confirmPsd);
    //})

    //注册3： input[type='button']触发submit()方法 提交不会刷新页面
    $("input[type='button']").click(function () {
        var userName = $("input[name='UserName']").val();
        var password = $("input[name='PassWord']").val();
        var confirmPsd = $("input[name='confirmPsd']").val();
        //判断字段是否全部填写
        if (inputValite(userName, password, confirmPsd)) {
            $(".register>form").submit();
        }
    })

    //判断字段是否全部填写
    function inputValite(userName, password, confirmPsd) {
        if (userName == "") {
            alert("请输入用户名");
            return false;
        }
        if (password == "") {
            alert("请输入密码");
            return false;
        }
        if (confirmPsd == "") {
            alert("请输入确认密码");
            return false;
        } else {
            if (password != confirmPsd) {
                alert("两次密码输入不一致");
                return false;
            }
        }
        return true;
    }
})