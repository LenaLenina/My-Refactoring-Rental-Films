using System;
using System.Collections.Generic;

namespace Refactoring
{
    /// <summary>
    /// Класс, представляющий клиента магазина.
    /// </summary>
    class Customer
    {
        // Поля

        private string name = null;
        private List<Rental> rentals = new List<Rental>();

        // Методы

        public Customer(string name)
        {
            this.name = name;
        }

        //  TODO: Метод Statement() - слишком громоздкий.

        /// <summary>
        /// Метод создающий отчет.
        /// </summary>
        /// <returns></returns>
        public string Statement()
        {
            string result = string.Format("Учет аренды для {0}: ", name);

            foreach (Rental rental in rentals)
            {
                result += "\t" + rental.Movie.Title + "\t" + rental.GetThisAmount() + "\n";
            }

            result += "Сумма задолженности составляет " + GetTotalAmount() + "\n";
            result += "Вы заработали " + GetFrequentRenterPoints() + " очков за активность";
            return result;
        }

        double GetTotalAmount()
        {
            double res = 0;

            foreach (Rental rental in rentals)
            {
                res += rental.GetThisAmount();
            }

            return res;
        }

        int GetFrequentRenterPoints()
        {
            int res = 0;

            foreach (Rental rental in rentals)
            {
                res += rental.GetFrequentRenterPoints();
            }

            return res;
        }

        public Rental Rentals
        {
            set { this.rentals.Add(value); }
        }

        public string Name
        {
            get { return this.name; }
        }
    }
}
