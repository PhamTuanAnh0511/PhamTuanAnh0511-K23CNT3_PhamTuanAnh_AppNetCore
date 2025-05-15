using System.ComponentModel.DataAnnotations;

namespace PtaLesson04.Models
{
    public class PtaBook
    {
        [Required(ErrorMessage = "Mã sách không được để trống")]
        public string? PtaId { get; set; }


        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        public string? PtaTitle { get; set; }

        public string? PtaDescription { get; set; }


        public string? PtaImage { get; set; }

        [Range(0.01, 1000, ErrorMessage = "Giá phải lớn hơn 0")]
        public float PtaPrice { get; set; }

        [Range(1, 2000, ErrorMessage = "Số trang phải từ 1 đến 2000")]
        public int PtaPage { get; set; }
    }

}
