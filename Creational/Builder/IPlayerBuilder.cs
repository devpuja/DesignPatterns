using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    internal interface IPlayerBuilder
    {
        void AddPlayButton();
        void StopPlayButton();
        Player BuildPlayer(); 
    }
}
