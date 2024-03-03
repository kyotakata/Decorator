using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Objects
{
    public class ComponentB : IComponent
    {
        public  virtual string GetData()
        {
            return File.ReadAllText("textB.txt");
        }
    }

    public sealed class CompornentBUpper : ComponentB
    {
        public CompornentBUpper()
        {
        }

        public override string GetData()
        {
            return base.GetData().ToUpper();
        }
    }

    public sealed class CompornentBLower : ComponentB
    {
        public CompornentBLower()
        {
        }

        public override string GetData()
        {
            return base.GetData().ToLower();
        }
    }


}
