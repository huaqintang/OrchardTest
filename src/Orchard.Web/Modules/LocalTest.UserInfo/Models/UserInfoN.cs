using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocalTest.UserInfo.Models
{
    public class UserInfoN
    {
        public virtual int Id { get; set; }
        public virtual string UserName{get;set;}
        public virtual string PassWord { get; set; }
    }
}