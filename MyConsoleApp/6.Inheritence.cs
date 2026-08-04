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
            return $"This is a pizza with {string.Join(',', ingredients.Select((i) => i.Name))}";
        }

    }

    public class Ingredient
    {
        public virtual string Name { get; set; } = "Hello Everyone";
        public Ingredient()
        {
            Console.WriteLine("Ingredient");
        }
        public string PublicMethod()
        {
            return "I am public method";
        }

        private string PrivateMethod()
        {
            return "I am private method";
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Cheddar : Ingredient
    {
        public Cheddar()
        {
            Console.WriteLine("Cheddar");
        }
        public override string Name => "Cheddar Cheese";
        public int AgeInMonths { get; }
    }

    public class TomatoSauce : Ingredient
    {
        public override string Name => "Tomato Sauce";
        public int TomatoesIn100Grams { get; }
    }

    public class Football
    {
        public int Trophies { get; }
        public Football(int tropy)
        {
           Trophies = tropy;
        }
    }

    public class Messi : Football
    {
        public Messi(int trophy) : base(trophy)
        {
            
        }
    }

}