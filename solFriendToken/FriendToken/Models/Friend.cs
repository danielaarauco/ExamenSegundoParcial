using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FriendToken.Models
{
    public class Friend
    {
        [key]
        public int FriendId { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }
        public string Nickname { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
    }
}