namespace PtaLab06.Models
{
    public class PtaEmployee
    {
        public int PtaId { get; set; }             // Mã nhân viên
        public string PtaName { get; set; }        // Họ và tên
        public DateTime PtaBirthDay { get; set; }  // Ngày sinh
        public string PtaEmail { get; set; }       // Email
        public string PtaPhone { get; set; }       // Số điện thoại
        public decimal PtaSalary { get; set; }     // Mức lương
        public bool PtaStatus { get; set; }        // Trạng thái (đang làm/nghỉ)
    }
}
