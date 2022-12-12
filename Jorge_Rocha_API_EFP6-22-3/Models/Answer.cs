﻿using System;
using System.Collections.Generic;

namespace Jorge_Rocha_API_EFP6_22_3.Models;

public partial class Answer
{
    public long AnswerId { get; set; }

    public int UserId { get; set; }

    public long AskId { get; set; }

    public DateTime Date { get; set; }

    public string Answer1 { get; set; } = null!;

    public bool? SetAsCorrect { get; set; }

    public bool? IsStrike { get; set; }

    public virtual Ask Ask { get; set; } = null!;

    public virtual ICollection<Like> Likes { get; } = new List<Like>();

    public virtual User User { get; set; } = null!;
}
