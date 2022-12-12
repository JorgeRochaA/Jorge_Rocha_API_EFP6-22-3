using System;
using System.Collections.Generic;

namespace Jorge_Rocha_API_EFP6_22_3.Models;

public partial class UserStatus
{
    public int UserStatusId { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<User> Users { get; } = new List<User>();
}
