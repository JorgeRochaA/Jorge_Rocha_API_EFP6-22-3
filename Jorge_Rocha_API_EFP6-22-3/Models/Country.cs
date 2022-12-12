using System;
using System.Collections.Generic;

namespace Jorge_Rocha_API_EFP6_22_3.Models;

public partial class Country
{
    public int CountryId { get; set; }

    public string CountryName { get; set; } = null!;

    public virtual ICollection<User> Users { get; } = new List<User>();
}
