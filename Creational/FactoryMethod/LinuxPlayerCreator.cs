using FactoryMethod_Demo;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod_Demo
{
    internal class LinuxPlayerCreator : PlayerCreator
    {
        public override Player CreatePlayer()
        {
            return new LinuxPlayer();
        }
    }
}
