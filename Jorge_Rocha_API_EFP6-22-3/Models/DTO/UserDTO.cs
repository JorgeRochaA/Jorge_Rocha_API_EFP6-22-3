﻿namespace Jorge_Rocha_API_EFP6_22_3.Models.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }

        public string UserName { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? PhoneNumber { get; set; }

        public string UserPassword { get; set; } = null!;

        public int StrikeCount { get; set; }

        public string BackUpEmail { get; set; } = null!;

        public string? JobDescription { get; set; }

        public int UserStatusId { get; set; }

        public int CountryId { get; set; }

        public int UserRoleId { get; set; }
    }
}
