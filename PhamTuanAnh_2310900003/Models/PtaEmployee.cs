using System;
using System.Collections.Generic;

namespace PhamTuanAnh_2310900003.Models;

public partial class PtaEmployee
{
    public int PtaEmpId { get; set; }

    public string? PtaEmpName { get; set; }

    public string? PtaEmpLevel { get; set; }

    public DateOnly? PtaEmpStartDate { get; set; }

    public bool? PtaEmpStatus { get; set; }
}
