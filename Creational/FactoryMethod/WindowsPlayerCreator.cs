using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod_Demo
{
    internal class WindowsPlayerCreator : PlayerCreator
    {
        public override Player CreatePlayer()
        {
            return new WindowsPlayer();
        }
    }
}
