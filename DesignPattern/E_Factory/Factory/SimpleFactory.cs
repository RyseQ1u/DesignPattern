using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.E_Factory.Product;

namespace DesignPattern.E_Factory.Factory
{
    internal class SimpleFactory
    {
        public static LeiFeng CreateLeiFeng(string type)
        {
            LeiFeng res = null;
            switch (type)
            {
                case "大学生":
                    res = new Undergraduate(); break;
                case "志愿者":
                    res = new Volunteer(); break;
            }
            return res;
        }
    }
}
