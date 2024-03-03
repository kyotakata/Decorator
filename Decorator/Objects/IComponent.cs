using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Objects
{
    public interface IComponent
    {
        string GetData();

        string GetDataUpper();

        string GetDataLower();
    }
}
