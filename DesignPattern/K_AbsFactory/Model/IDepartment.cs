﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.K_AbsFactory.Model
{
    internal interface IDepartment
    {
        void Insert(Department department);

        Department GetDepartment(int id);
    }
}