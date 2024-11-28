﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.F_Prototype.Prototype
{
    internal abstract class Prototype
    {
        private string id;

        public Prototype(string id)
        {
            this.id = id;
        }

        public string Id { get => id; }

        public abstract Prototype Clone();
    }
}
