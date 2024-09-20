using System.Runtime.CompilerServices;

public class Order
{
    public int Id { get; set; }
    public DateTime? Date { get; set; }
    public string? status { get; set; }
    List<OrderLine> OrderLines { get; set; }
}