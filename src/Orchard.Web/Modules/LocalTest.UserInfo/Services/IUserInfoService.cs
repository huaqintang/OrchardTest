using LocalTest.UserInfo.Models;
using Orchard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalTest.UserInfo.Services
{
    public interface IUserInfoService : IDependency 
    {
        UserInfoN Register(string userName, string passWord);
        UserInfoN Login(string userName, string passWord);
    }
}
