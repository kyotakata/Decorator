using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Objects
{
    // 1．同じインタフェースの実装にする
    public sealed class DecoratorUpper : Decorator
    {
        public DecoratorUpper(IComponent child) : base(child)
        {
        }

        protected override string GetDataSub()
        {
            return _child.GetData().ToUpper();
        }

        protected override int GetPriceSub()
        {
            return 40;
        }

    }

}
