using System.Drawing;
using SchoolBag.Models.Items;

namespace SchoolBag.Repos;

public class SchoolBagsRepo
{
    public List<Models.Items.SchoolBag> SchoolBags { get; set; } = new()
    {
        new ()
        {
            Name = "Alexanders taske",
            Condition = 0.75,
            WeightInGrams = 2100,
            PencilCase = new PencilCase()
            {
                Name = "Alexanders penalhus",
                Condition = 0.75,
                Pencils = new List<Pencil>
                {
                    new ()
                    {
                        Name = "Alexanders blyant 1",
                        Color = Color.Aqua,
                        Condition = 0.5,
                        WeightInGrams = 50
                    },
                    new ()
                    {
                        Name = "Alexanders blyant 2",
                        Color = Color.Aqua,
                        Condition = 0.8,
                        WeightInGrams = 50
                    },
                    new ()
                    {
                        Name = "Alexanders blyant 3",
                        Color = Color.Aqua,
                        Condition = 1,
                        WeightInGrams = 50
                    }
                },
                Erasers = new List<Eraser>
                {
                    new ()
                    {
                        Name = "Alexanders viskelæder 1",
                        Condition = 0.12,
                        WeightInGrams = 10,
                        Smell = "Foul"
                    },
                    new ()
                    {
                        Name = "Alexanders viskelæder 2",
                        Condition = 1,
                        WeightInGrams = 120,
                        Smell = "Good"
                    }
                }
            },
            Books = new List<Book>
            {
                new ()
                {
                    Name = "Kongens nye klæder",
                    Condition = 0.22,
                    WeightInGrams = 500,
                    Author = "H. C. Andersen"
                }
            },
            LunchBox = new LunchBox()
            {
                Name = "Alexanders madkasse",
                Condition = 0.74,
                WeightInGrams = 1000,
                Food = new List<Food>
                {
                    new Food()
                    {
                        Name = "Æble",
                        Calories = 100,
                        Condition = 0.88,
                        WeightInGrams = 100
                    }
                }
            }
        },
        new ()
        {
            Name = "Vanessas taske",
            Condition = 0.75,
            WeightInGrams = 2100,
            PencilCase = new PencilCase()
            {
                Name = "Vanessas penalhus",
                Condition = 0.75,
                Pencils = new List<Pencil>
                {
                    new ()
                    {
                        Name = "Vanessas blyant 1",
                        Color = Color.Aqua,
                        Condition = 0.5,
                        WeightInGrams = 50
                    },
                    new ()
                    {
                        Name = "Vanessas blyant 2",
                        Color = Color.Aqua,
                        Condition = 0.8,
                        WeightInGrams = 50
                    },
                    new ()
                    {
                        Name = "Vanessas blyant 3",
                        Color = Color.Aqua,
                        Condition = 1,
                        WeightInGrams = 50
                    }
                },
                Erasers = new List<Eraser>
                {
                    new ()
                    {
                        Name = "Vanessas viskelæder 1",
                        Condition = 0.12,
                        WeightInGrams = 10,
                        Smell = "Foul"
                    },
                    new ()
                    {
                        Name = "Vanessas viskelæder 2",
                        Condition = 1,
                        WeightInGrams = 120,
                        Smell = "Good"
                    }
                }
            },
            Books = new List<Book>
            {
                new ()
                {
                    Name = "Den grimme ælling",
                    Condition = 0.22,
                    WeightInGrams = 500,
                    Author = "H. C. Andersen"
                }
            },
            LunchBox = new LunchBox()
            {
                Name = "Vanessas madkasse",
                Condition = 0.74,
                WeightInGrams = 1000,
                Food = new List<Food>
                {
                    new Food()
                    {
                        Name = "Banan",
                        Calories = 100,
                        Condition = 0.88,
                        WeightInGrams = 100
                    }
                }
            }
        }
    };
}