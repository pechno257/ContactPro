using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContactPro.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A]|[I]$")]
        public string Status { get; set; } = "A";

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Company")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "{0} number is required.")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Must be in the following format: 555-555-5555")]
        public string Phone { get; set; }

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Must be in the following format: 555-555-5555")]
        public string Fax { get; set; }

        

        [Display(Name = "Xcelerator URL")]
        [RegularExpression(@"^(https:\/\/www\.|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,10}(:[0-9]{1,5})?(\/.*)?$", ErrorMessage = "Invalid URL.")]
        public string XceleratorURL { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        [RegularExpression(@"^[A-Z]{2}$", ErrorMessage = "{0} must be a 2-letter abbreviation.")]
        public string State { get; set; }

        [RegularExpression(@"^\d{5}-\d{4}|\d{5}|[A-Z]\d[A-Z] \d[A-Z]\d$", ErrorMessage = "Invalid {0} code.")]
        public string Zip { get; set; }

        [Required(ErrorMessage ="{0} is required.")]
        public string Country { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public DateTime DateModified { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Please select an option.")]
        [Display(Name = "Hosted?")]
        public string IsHosted { get; set; }

        [Display(Name = "Hosted Server")]
        public string HostedServer { get; set; }
    }
}

