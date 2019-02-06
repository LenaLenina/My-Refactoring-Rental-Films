using System;
using Ref3;

// TODO: Слабо спроектированная программа. (Не объектно-ориентированная)

// Программа расчитывает и выводит отчет об оплате клиентом услуг в магазине видеопроката.
// Программе сообщается, какие фильмы брал в прокате клиент и на какой срок. 
// После этого программа рассчитывает сумму платежа исходя из продолжительности проката и типа фильма.
// Фильмы бывают трех типов: обычные, детские и новинки. Помимо расчета суммы оплаты начисляются бонусы 
// в зависимости от того, является ли фильм новым.

namespace Refactoring
{
    class Program
    {
        static void Main()
        {
            Customer customer = new Customer("Alex");
            Movie movie = new Movie("Matrix", new PriceNewRelease());
            Rental rental = new Rental(movie, 2);

            customer.Rentals = rental;

            Movie movie2 = new Movie("Shrek", new PriceChildrens());
            Rental rental2 = new Rental(movie2, 2);

            customer.Rentals = rental2;

            Console.WriteLine(customer.Statement());

            // Delay.
            Console.ReadKey();
        }
    }
}
