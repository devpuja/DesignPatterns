using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod_Demo
{
    internal abstract class Player
    {
        public abstract Task Play(string FileName);
    }
}
