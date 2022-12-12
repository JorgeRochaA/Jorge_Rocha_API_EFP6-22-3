using System;
using System.Collections.Generic;

namespace Jorge_Rocha_API_EFP6_22_3.Models;

public partial class AskStatus
{
    public int AskStatusId { get; set; }

    public string AskStatus1 { get; set; } = null!;

    public virtual ICollection<Ask> Asks { get; } = new List<Ask>();
}
