using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Consultation:Strateg
    {
        public override void DoIt()
        {
            Console.WriteLine("Подскажите пожалуйста, где можно найти...");
        }
    }
}
