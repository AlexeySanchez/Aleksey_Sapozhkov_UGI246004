using System;
using System.Collections;
using System.Collections.Generic;

namespace Class_Dish
{
    public class Menu : IEnumerable<Dish>
    {
        private readonly DateTime date;
        private readonly List<Dish> dishes;

        public Menu(DateTime date, IEnumerable<Dish> dishes)
        {
            this.date = date;
            this.dishes = new List<Dish>();

            foreach (var dish in dishes)
                this.dishes.Add(dish);
        }

        public Menu(string date, IEnumerable<Dish> dishes)
            : this(DateTime.Parse(date), dishes)
        {
        }

        public IEnumerator<Dish> GetEnumerator()
        {
            return dishes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
