using System;
using System.Collections.Generic;

class Coocking
{
    public enum Dimension
    {
        tablespoons = 15,        tbsps = -15,        
        ls = -1000,        liters = 1000,
        fluidOunces = 30,        flOzs = -30,
        teaspoons = 5,        tsps = -5,
        gallons = 3840,        gals = -3840,
        pints = 480,        pts = -480,
        quarts = 960,        qts = -960,
        cups = 240,
        milliliters = 1,        mls =-1,
    }

    ;
    public class Product : IEquatable<Product>
    {
        public decimal amount;
        public Dimension dimension;
        public string name;

        public Product(string name, decimal amount, Dimension dimension)
        {
            this.name = name;
            this.amount = amount;
            this.dimension = dimension;
        }

        public bool Equals(Product other)
        {
            if (this.name.Equals(other.name, StringComparison.OrdinalIgnoreCase))            
                return true;            
            else            
                return false;            
        }
    }
    
    class Recipe
    {
        private List<Product> Products;

        public Recipe(int count)
        {
            Products = new List<Product>(count);
        }

        public void Add(string name, decimal amount, Dimension dimension)
        {
            Product element = new Product(name, amount, dimension);
            int indexElement = Products.IndexOf(element);
            if (indexElement == -1)
            {
                Products.Add(element);
            }
            else
            {
                if (element.dimension == Products[indexElement].dimension)
                {
                    Products[indexElement].amount += element.amount;
                }
                else
                {
                    decimal convertedAmount = ConvertDimensions(element.amount, element.dimension, Products[indexElement].dimension);
                    Products[indexElement].amount += convertedAmount;
                }
            }
        }

        public void Remove(string name, decimal amount, Dimension dimension)
        {
            Product element = new Product(name, amount, dimension);
            int indexElement = Products.IndexOf(element);
            if (indexElement == -1)
            {
                return;
            }
            else
            {
                if (element.dimension == Products[indexElement].dimension)
                {
                    Products[indexElement].amount -= element.amount;
                }
                else
                {
                    decimal convertedAmount = ConvertDimensions(element.amount, element.dimension, Products[indexElement].dimension);
                    Products[indexElement].amount -= convertedAmount;
                }
            }
        }

        public void ShowLeft()
        {
            foreach (Product element in Products)
            {
                if (element.amount <= 0)
                {
                    continue;
                }
                else
                {
                    if (element.dimension == Dimension.flOzs)
                    {
                        Console.WriteLine("{0:F2}:fl ozs:{1}", element.amount, element.name);
                    }
                    else if (element.dimension == Dimension.fluidOunces)
                    {
                        Console.WriteLine("{0:F2}:fluid ounces:{1}", element.amount, element.name);
                    }
                    else
                    {
                        Console.WriteLine("{0:F2}:{1}:{2}", element.amount,element.dimension.ToString(), element.name);
                    }
                }
                
            }
        }
        private decimal ConvertDimensions(decimal amount, Dimension input, Dimension output)
        {
            decimal tempMls = 0.0M;
            decimal result = 0.0M;
            tempMls = amount * Math.Abs((int)input);
            result = tempMls / Math.Abs((int)output);
            return result;
        }
    }
    static void Main()
    {       
        int recipeElements = int.Parse(Console.ReadLine());
        Recipe recipe = new Recipe(recipeElements);
        for (int i = 0; i < recipeElements; i++)
        {
            string name;
            decimal amount;
            Dimension dimension;
            ParseValues(out name, out amount, out dimension);            
            recipe.Add(name, amount, dimension);
        }
        int elementsAdded = int.Parse(Console.ReadLine());
        for (int i = 0; i < elementsAdded; i++)
        {
            string name;
            decimal amount;
            Dimension dimension;
            ParseValues(out name, out amount, out dimension); 
            recipe.Remove(name, amount, dimension);
        }
        recipe.ShowLeft();
    }
  
    private static void ParseValues(out string name, out decimal amount, out Dimension dimension)
    {
        string rawFormat = Console.ReadLine();
        int colonIndex = rawFormat.IndexOf(":"),
        nextColonIndex = rawFormat.IndexOf(":", colonIndex + 1);
        string rawAmount = rawFormat.Substring(0, colonIndex);
        string rawDimension = rawFormat.Substring(colonIndex + 1, nextColonIndex - colonIndex - 1);
        name = rawFormat.Substring(nextColonIndex + 1);
        amount = decimal.Parse(rawAmount);        
        if (rawDimension == "fluid ounces")
        {
            dimension = Dimension.fluidOunces;
        }
        else if (rawDimension == "fl ozs")
        {
            dimension = Dimension.flOzs;
        }
        else
        {
            dimension = (Dimension)Enum.Parse(typeof(Dimension), rawDimension);
        }
    }
}