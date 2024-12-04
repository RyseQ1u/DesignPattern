using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.N_Composite.Companys
{
    internal abstract class Company
    {
        protected Company(string name)
        {
            this.name = name;
        }

        public string name { get; set; }

        public abstract void Add(Company c);

        public abstract void Remove(Company c);

        public abstract void Display(int depth);

        /// <summary>
        /// do something..
        /// </summary>
        public abstract void LineOfDuty();
    }
}