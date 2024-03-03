using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Objects
{
    // 1．同じインタフェースの実装にする
    public sealed class DecoratorLower : Decorator
    {
        public DecoratorLower(IComponent child) : base(child)
        {
        }

        protected override string GetDataSub()
        {
            return _child.GetData().ToLower();
        }

        protected override int GetPriceSub()
        {
            return 30;
        }
    }

}
