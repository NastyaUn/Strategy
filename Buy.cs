using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Buy:Strateg
    {
        public override void DoIt()
        {
            Console.WriteLine("Здравствуйте, я бы хотел купить...");
        }
    }
}
