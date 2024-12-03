using DesignPattern.K_AbsFactory.Model;
using DesignPattern.K_AbsFactory.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DesignPattern.K_AbsFactory.Factory
{
    internal class DataAccess
    {
        //private static readonly string DB = "SqlServer";
        //private static readonly string db = "Access";

        private static readonly string DB = ConfigurationManager.AppSettings["DB"];
        private static readonly string ClassName = "DesignPattern.K_AbsFactory.SQL";
        private static readonly string AssemblyName = "DesignPattern";

        #region V1

        //public static IUser CreateUser()
        //{
        //    IUser user = null;
        //    switch (db)
        //    {
        //        case "Sql Server":
        //            user = new SqlServerUser();
        //            break;

        //        case "Access":
        //            user = new AccessUser();
        //            break;
        //    }
        //    return user;
        //}

        //public static IDepartment CreateDepartment()
        //{
        //    IDepartment depart = null;
        //    switch (db)
        //    {
        //        case "Sql Server":
        //            depart = new SqlServerDepartment();
        //            break;

        //        case "Access":
        //            depart = new AccessDepartment();
        //            break;
        //    }
        //    return depart;
        //}

        #endregion V1

        #region V2 反射

        public static IUser CreateUser()
        {
            IUser user = null;
            var className = ClassName + "." + DB + "User";
            user = (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
            return user;
        }

        public static IDepartment CreateDepartment()
        {
            IDepartment depart = null;
            var className = ClassName + "." + DB + "Department";
            depart = (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
            return depart;
        }

        #endregion V2 反射
    }
}