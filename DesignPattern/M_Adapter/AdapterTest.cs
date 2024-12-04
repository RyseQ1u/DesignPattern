using DesignPattern.M_Adapter.Adapters;
using DesignPattern.M_Adapter.Players;
using DesignPattern.M_Adapter.Translators;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.M_Adapter
{
    internal class AdapterTest
    {
        public void Run()
        {
            #region V1

            //var t = new Adapter();
            //t.Request();

            #endregion V1

            #region V2

            //var f = new Forwards("大大大前锋");
            //f.Attack();
            //var g = new Guards("小小小后卫");
            //g.Attack();
            //var c = new Center("高高高中锋");
            //c.Attack();
            //c.Defense();

            #endregion V2

            #region V3

            var f = new Forwards("大大大前锋");
            f.Attack();
            var g = new Guards("小小小后卫");
            g.Attack();
            var c = new Translator("高高高中锋");
            c.Attack();
            c.Defense();

            #endregion V3
        }
    }
}