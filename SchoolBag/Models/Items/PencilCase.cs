using SchoolBag.Models.Base;

namespace SchoolBag.Models.Items;

public class PencilCase : ItemBase
{
    public List<Pencil> Pencils { get; set; }
    public List<Eraser> Erasers { get; set; }
    
    public override string ToString()
    {
        var pencilsStr = "";
        var ErasersStr = "";
        
        pencilsStr = string.Join("", Pencils.Select(p => $"{p.ToString()}").ToArray());
        ErasersStr = string.Join("", Pencils.Select(p => $"{p.ToString()}").ToArray());
        return $"{base.ToString()}Items: \n{pencilsStr}{ErasersStr}";
    }
}