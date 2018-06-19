using System;
using System.Collections.Generic;
using System.Data;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace LocalTest.UserInfo {
    public class Migrations : DataMigrationImpl {

        public int Create() {
            SchemaBuilder.CreateTable("UserInfo", table => table
                 .Column("Id", DbType.Int32, column => column.PrimaryKey().Identity())
                 .Column("UserName", DbType.String)
                 .Column("PassWord",DbType.String)
            );
            return 1;
        }

        public int UpdateFrom1()
        {
            SchemaBuilder.CreateTable("UserInfoN", table => table
                 .Column("Id", DbType.Int32, column => column.PrimaryKey().Identity())
                 .Column("UserName", DbType.String)
                 .Column("PassWord", DbType.String)
            );
            return 2;
        }
    }
}