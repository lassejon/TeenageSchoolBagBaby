namespace SchoolBag.Models.Base;

public abstract class ItemBase
{
    public string Name { get; set; }

    public double Condition { get; set; }

    public int WeightInGrams { get; set; }

    public override string ToString()
    {
        return $"{GetType().Name}:\n" +
               $"{Name} - condition: {Condition}\n";
    }
}