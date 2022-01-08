using System;

namespace Strategy
{
    class Program
    {
		static void Main(string[] args)
		{
			// Создаем покупателей с выбранной стратегией поведения
			BuyerClothes buyerC = new BuyerClothes(new Open());
			BuyerBook buyerB= new BuyerBook(new Open());
			Console.WriteLine("Стратегия покупателя в магазине одежды");
			buyerC.DoSomething();
			buyerC.Strategy = new Search();
			// Заставляем его 2 раза что-то найти
			for (int i = 0; i < 2; i++)
			{
				buyerC.DoSomething();
			}
			// меняем стратегию
			buyerC.Strategy = new Consultation();
			buyerC.DoSomething();
			buyerC.Strategy = new Buy();
			buyerC.DoSomething();
			Console.WriteLine("\nСтратегия покупателя в книжном магазине");
			//описываем стратегию другого покупателя
			buyerB.DoSomething();
			buyerB.Strategy = new Consultation();
			buyerB.DoSomething();
			buyerB.Strategy = new Buy();
			buyerB.DoSomething();
		}
    }
}
