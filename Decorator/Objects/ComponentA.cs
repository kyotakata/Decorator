using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Objects
{
    public class ComponentA : IComponent
    {
        public  virtual string GetData()
        {
            return File.ReadAllText("textA.txt");
        }
    }

    public sealed class CompornentAUpper : ComponentA
    {
        public CompornentAUpper()
        {
        }

        public override string GetData()
        {
            return base.GetData().ToUpper();
        }
    }

}
