using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod_Demo
{
    internal abstract class PlayerCreator
    {
        public abstract Player CreatePlayer();
    }
}
