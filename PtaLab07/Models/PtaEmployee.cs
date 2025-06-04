using System;

namespace PtaLab07.Models
{
    public class PtaEmployee
    {
        public long PtaId { get; set; }


        public string PtaName { get; set; }
        public DateTime PtaBirthDay { get; set; }
        public string PtaEmail { get; set; }
        public string PtaPhone { get; set; }
        public decimal PtaSalary { get; set; }
        public bool PtaStatus { get; set; }
    }
}
