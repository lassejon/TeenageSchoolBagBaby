using SchoolBag.Models.Base;

namespace SchoolBag.Models.Items;

public class SchoolBag : ItemBase
{
    public PencilCase PencilCase { get; set; }
    public List<Book> Books { get; set; }
    public LunchBox LunchBox { get; set; }
    
    public override string ToString()
    {
        var booksStr = "";
        
        booksStr = string.Join("", Books.Select(b => $"{b.ToString()}").ToArray());
        return $"{base.ToString()}" +
               $"{PencilCase}" +
               $"{LunchBox} \n" +
               $"Books:\n" +
               $"{booksStr}";
    }
}