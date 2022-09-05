using System.Text;
using SchoolBag.Models.Base;

namespace SchoolBag.Models.Items;

public class LunchBox : ItemBase
{
    public List<Food> Food { get; set; }

    public override string ToString()
    {
        var foodStr = "";
        
        foodStr = string.Join("", Food.Select(f => $"{f.ToString()}calories: {f.Calories}").ToArray());
        return $"{base.ToString()}{foodStr}";
    }
}