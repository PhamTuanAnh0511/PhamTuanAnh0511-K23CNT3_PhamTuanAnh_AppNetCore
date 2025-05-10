using Lesson02.Models;

public class PtaMotoCategoryViewModel
{
    // Danh sách các mô tô
    public List<PtaMoto> Motos { get; set; } = new List<PtaMoto>();

    // Danh sách các danh mục
    public List<PtaCategory> Categories { get; set; } = new List<PtaCategory>();
}
