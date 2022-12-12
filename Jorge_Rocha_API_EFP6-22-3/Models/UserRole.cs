using System;
using System.Collections.Generic;

namespace Jorge_Rocha_API_EFP6_22_3.Models;

public partial class UserRole
{
    public int UserRoleId { get; set; }

    public string UserRole1 { get; set; } = null!;

    public bool IsUserSelectable { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}
