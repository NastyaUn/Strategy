using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class BuyerBook
    {
		Strategy.Strateg strat;// поле для хранения стратегии
		public BuyerBook(Strategy.Strateg strat)//конструктор для создания стратегии
		{
			this.strat = strat;
		}
		// Свойство, позволяющее узнать и задать текущую стретегию поведения.
		public Strategy.Strateg Strategy
		{
			get { return strat; }
			set { strat = value; }
		}
		// Выполнение текущего действия
		public void DoSomething()
		{
			strat.DoIt();
		}
	}
}
