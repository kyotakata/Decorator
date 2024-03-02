using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Objects
{
    public sealed class ComponentB : IComponent
    {
        private bool _isUpper = false;

        private bool _isLower = false;
        
        public ComponentB(bool isUpper, bool isLower)
        {
            _isUpper = isUpper;
            _isLower = isLower;
        }

        public string GetData()
        {
            var result = File.ReadAllText("textB.txt");
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
