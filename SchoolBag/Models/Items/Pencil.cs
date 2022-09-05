using System.Drawing;
using SchoolBag.Models.Base;

namespace SchoolBag.Models.Items;

public class Pencil : ItemBase
{
    public Color Color { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()}color: {Color} \n";
    }
}