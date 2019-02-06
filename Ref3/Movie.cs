using System;
using Ref3;

namespace Refactoring
{
    /// <summary>
    /// Класс, который предоставляет данные о фильме.
    /// </summary>
    class Movie
    {
        private string title = null;
        Price price;

        public Movie(string title, Price price)
        {
            this.title = title;
            this.price = price;
        }

        public Price Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Title
        {
            get { return this.title; }
        }
    }
}
