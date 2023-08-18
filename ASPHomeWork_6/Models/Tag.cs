namespace ASPHomeWork_6.Models;

public class Tag
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
