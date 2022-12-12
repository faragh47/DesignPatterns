﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class GammaFilter : IFilter
    {
        public void apply(string fileName)
        {
            Console.WriteLine("apply Gamma Filter on Image");
        }
    }
}
