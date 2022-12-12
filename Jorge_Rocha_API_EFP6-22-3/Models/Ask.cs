using System;
using System.Collections.Generic;

namespace Jorge_Rocha_API_EFP6_22_3.Models;

public partial class Ask
{
    public long AskId { get; set; }

    public DateTime Date { get; set; }

    public string AskDescription { get; set; } = null!;

    public int UserId { get; set; }

    public int AskStatusId { get; set; }

    public bool? IsStrike { get; set; }

    public string? ImageUrl { get; set; }

    public string? AskDetail { get; set; }

    public virtual ICollection<Answer> Answers { get; } = new List<Answer>();

    public virtual AskStatus? AskStatus { get; set; } = null!;

    public virtual User? User { get; set; } = null!;
}
