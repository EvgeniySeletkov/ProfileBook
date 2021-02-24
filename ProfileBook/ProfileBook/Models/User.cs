using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProfileBook.Models
{
    [Table("Users")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
