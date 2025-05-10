public class PtaMoto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Avatar { get; set; }  // Đây là trường chứa đường dẫn hình ảnh
    public decimal Price { get; set; }
    public decimal SalePrice { get; set; }
    public int CategoryId { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedAt { get; set; }
}
