using HomeWorkPolyakov3_1P9;
using System;
using System.Windows.Controls;

namespace HomeWorkPolyakov3_1P9
{
    internal class Onlinestore
    {
        Infsystem infsystem;
        Webpage webpage;
        Computer computer;
        public Onlinestore(Computer computer)
        {
            infsystem = new Infsystem();
            webpage = new Webpage();
            this.computer = computer;
        }
    }
}