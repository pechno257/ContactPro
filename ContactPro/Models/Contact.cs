using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContactPro.Models
{
    public class Contact
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A]|[I]$")]
        public string Status { get; set; } = "A";

        [Required(ErrorMessage ="{0} is required.")]
        [Display(Name = "Company")]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Name")]
        public string FullName => FirstName + " " + LastName;

        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        [ReadOnly(true)]
        public string Phone => Customer.Phone;

        [Display(Name = "Direct Line")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Must be in the following format: 555-555-5555")]
        public string DirectLine { get; set; }

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Must be in the following format: 555-555-5555")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [RegularExpression(@"^^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "{0} address is not valid.")]
        public string Email { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public DateTime DateModified { get; set; } = DateTime.Now;

        public Customer Customer { get; set; }
    }
}

