using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Objects
{
    public sealed class ComponentA : IComponent
    {
        private bool _isUpper = false;

        private bool _isLower = false;
        
        public ComponentA(bool isUpper, bool isLower)
        {
            _isUpper = isUpper;
            _isLower = isLower;
        }

        public string GetData()
        {
            var result = File.ReadAllText("textA.txt");
            if (_isUpper)
            {
                return result.ToUpper();
            }
            else if (_isLower)
            {
                return result.ToLower();

            }

            return result;
        }
    }
}
