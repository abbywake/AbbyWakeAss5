using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbbyWakeAss5.Models
{
    //making all of the nice little things to be put inside of the database/table. 
    //settings them to be required (except for the AUthor Middle name because it doesn't have it for some of them)
    //and giving a regular expression for the ISBN
    public class Books
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorFirst { get; set; }
        
        public string? AuthorMiddle { get; set; }
        [Required]
        public string AuthorLast { get; set; }

        [Required]
        public string Publisher { get; set; }
        [Required]
        [RegularExpression("[0-9]{3}-[0-9]{10}")]
        public int ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public float Price { get; set; }


    }
}
