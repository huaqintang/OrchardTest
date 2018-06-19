using LocalTest.UserInfo.Models;
using Orchard.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocalTest.UserInfo.Services
{
    public class UserInfoService : IUserInfoService
    {
        //实例化对象 <models名称>
        private readonly IRepository<UserInfoN> _userInforepository;//操作数据库的表
        public UserInfoService(
            IRepository<UserInfoN> userInforepository

        )
        {
            _userInforepository = userInforepository;
        }

        //注册方法
        public UserInfoN Register(string userName, string passWord)
        {
            UserInfoN userInfo = null;
            if (!String.IsNullOrEmpty(userName) && !String.IsNullOrEmpty(passWord)) {
                userInfo = new UserInfoN { UserName = userName, PassWord = passWord };
                _userInforepository.Create(userInfo);
            }
           
            return userInfo;
        }

        public UserInfoN Login(string userName, string passWord)
        {
            UserInfoN userInfoN = _userInforepository.Table
                .Where(p => p.UserName == userName && p.PassWord == passWord)
                .FirstOrDefault();
            /*IList<UserInfoN> userInfoN = _userInforepository.Table
                .Where(p => p.UserName == userName && p.PassWord == passWord)
                .ToList();*/
            return userInfoN;
        }
    }
}