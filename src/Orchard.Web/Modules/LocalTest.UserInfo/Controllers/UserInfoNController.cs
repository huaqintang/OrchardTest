using LocalTest.UserInfo.Models;
using LocalTest.UserInfo.Services;
using Orchard.Data;
using Orchard.Mvc.AntiForgery;
using Orchard.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace LocalTest.UserInfo.Controllers
{
    public class UserInfoNController : Controller
    {
        private readonly IUserInfoService _userInfoService;

        public UserInfoNController(
            IUserInfoService userInfoService
        )
        {
            _userInfoService = userInfoService;
        }

        //主界面home
        public ActionResult Home() {
            return View();
        }

        //注册页面
        [Themed]
        public ActionResult Register()
        {
            return View();
        }
        //登录页面
        [Themed]
        public ActionResult Login()
        {
            return View();
        }

        //Register方法1： Ajax 调用
        //[HttpPost,ValidateAntiForgeryTokenOrchard(false)]
        //public JsonResult Register(string userName, string passWord)
        //{
        //    UserInfoN user = _userInfoService.Register(userName, passWord);
        //    if (user == null)
        //    {
        //        return JsonResult(false, null, "注册失败");
        //    }

        //    return JsonResult(true, null, "注册成功");
        //}

        //Register方法2：form表单提交
        [HttpPost, ValidateAntiForgeryTokenOrchard(false)]
        public ActionResult Register(string userName, string passWord)
        {
            UserInfoN user = _userInfoService.Register(userName, passWord);
            if (user == null)
            {
                return RedirectToAction("Register", new { });
            }
            return RedirectToAction("Login");
        }

        //登录
        [HttpPost]
        public JsonResult Login(string username, string psd)
        {
            UserInfoN userInfoN = _userInfoService.Login(username, psd);
            if (userInfoN == null)
            {
                return JsonResult(false, null, "登录失败");
            }
            return JsonResult(true, null, "登陆成功");
        }

        public JsonResult JsonResult(bool success, object data = null, string errMsg = "")
        {
            return new JsonResult
            {
                ContentEncoding = Encoding.UTF8,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = new { Success = success, Data = data, ErrMsg = errMsg }
            };
        }
    }
}