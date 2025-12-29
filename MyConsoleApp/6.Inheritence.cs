using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyConsoleApp
{
    public class Pizza
    {
        private List<Ingredient> ingredients = new List<Ingredient>();

        public void AddIngredient(Ingredient ingredient)
        {
            ingredients.Add(ingredient);
        }

        public string Describe()
        {
            return $"This is a pizza with {string.Join(',', ingredients.Select((i)=>i.Name))}";
        }

    }

    public class Ingredient
    {
        public virtual string Name { get; set; }
    }

    public class Cheddar : Ingredient
    {
        public override string Name => "Cheddar Cheese";
        public int AgeInMonths { get; }
    }

    public class TomatoSauce : Ingredient
    {
        public override string Name => "Tomato Sauce";
        public int TomatoesIn100Grams { get; }
    }
}
