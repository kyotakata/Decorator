﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Objects
{
    public class ComponentA : IComponent
    {
        public  string GetData()
        {
            return File.ReadAllText("textA.txt");
        }

        public string GetDataUpper()
        {
            return File.ReadAllText("textA.txt").ToUpper();
        }


        public string GetDataLower()
        {
            return File.ReadAllText("textA.txt").ToLower();
        }

    }

}
