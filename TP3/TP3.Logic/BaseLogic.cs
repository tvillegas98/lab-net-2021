﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Data;

namespace TP4.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext context;

        public BaseLogic()
        {
            context = new NorthwindContext();
        }
    }
}
