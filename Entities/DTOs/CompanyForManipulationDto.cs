﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CompanyForManipulationDto
    {
        [Required(ErrorMessage = "Company name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address is a required field.")]
        [MaxLength(50, ErrorMessage = "Maximum length for the Address is 50 characters.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Address is a required field.")]
        [MaxLength(50, ErrorMessage = "Maximum length for the Address is 50 characters.")]
        public string Country { get; set; }
        public IEnumerable<EmployeeForCreationDto> Employees { get; set; }

    }
}
