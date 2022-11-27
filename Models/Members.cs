using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Authentication.Models
{
    public class Members
    {
        public int ID { get; set; }
        [Required]
        [StringLength(30,ErrorMessage ="Please enter your first name using 30 characters or less.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Please enter your last name using 30 characters or less.")]
        [Display (Name ="Last Name")]
        public string LastName { get; set; }
        [StringLength(50, ErrorMessage = "Please enter your address using 50 characters or less.")]
        public  string Address { get; set; }
        [StringLength(30, ErrorMessage = "Please enter the city using 30 characters or less.")]
        public string City { get; set; }
        [StringLength(2, ErrorMessage = "Please enter the state using 2 characters.")]
        public string State { get; set; }
        [StringLength(10, ErrorMessage = "Zipcode has a maximum length of 10 numbers.")]
        public string Zip { get; set; }
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Cell#")]
        public string MobilePhone { get; set; }

        public ICollection<ParentChild> Children { get; set; }
    }
}