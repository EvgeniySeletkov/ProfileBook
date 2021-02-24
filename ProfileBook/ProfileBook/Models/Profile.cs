using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProfileBook.Models
{
    [Table("Profiles")]
    public class Profile
    {
        [PrimaryKey, AutoIncrement]
        public int ProfileId { get; set; }
        public string NickName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
