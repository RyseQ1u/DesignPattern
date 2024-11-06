using DesignPattern.C_Decorator.CncreteComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.C_Decorato.Dcorator
{
    /// <summary>
    /// 服饰类
    /// </summary>
    public class Finery : Man
    {
        protected Man component;

        //打扮
        public void Decorate(Man component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if (component != null)
                component.Show();
        }
    }
}