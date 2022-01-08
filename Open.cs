using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Open : Strateg
    {
        public override void DoIt()
        {
            Console.WriteLine("/Покупатель аходит в магазин/");
        }
    }
}
