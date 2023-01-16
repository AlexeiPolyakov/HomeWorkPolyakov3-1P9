using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPolyakov3_1P9
{
    internal class Computer
    {
        Mouse mouse;
        Screen screen;
        Keyboard keyboard;
        Systemunit systemunit;
        public Computer(Mouse mouse, Screen screen, Keyboard keyboard, Systemunit systemunit)
        {
            this.mouse = mouse;
            this.screen = screen;
            this.keyboard = keyboard;
            this.systemunit = systemunit;
        }
    }
}
