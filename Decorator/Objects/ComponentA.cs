using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Objects
{
    public sealed class ComponentA : IComponent
    {
        public string GetData()
        {
            return File.ReadAllText("textA.txt");
        }
    }
}
