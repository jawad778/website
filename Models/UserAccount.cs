using System;
using System.Collections.Generic;

namespace Crud.Models
{
    public partial class UserAccount
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string? Useremail { get; set; }
        public string UserDasignation { get; set; } = null!;
        public string? UserResume { get; set; }
    }
}
