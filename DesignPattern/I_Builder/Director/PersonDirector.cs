using DesignPattern.I_Builder.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.I_Builder.Director
{
    internal class PersonDirector
    {
        private PersonBuilder builder;

        public PersonDirector(PersonBuilder builder)
        {
            this.builder = builder;
        }

        public void CreatePerson()
        {
            builder.BuildLegLeft();
            builder.BuildLegRight();
            builder.BuildArmRight();
            builder.BuildArmLeft();
            builder.BuildBody();
            builder.BuildHead();
        }
    }
}