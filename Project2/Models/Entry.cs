using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//data entry verification
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace Project2.Models
{
    public class Entry : CreationDate //CreationDate Inheritance used for Submission Date
    {


        //add code first migration (pg 61 textbook) if you want to change anything here
        //primary key required for creating controller/views - don't delete this
        [Required]
        public int Id { get; set; }


        [Required]
        [Display(Name = "First Name")]
        public string NameFirst { get; set; }

        [Required]
        [Display(Name = "Middle Name (if none, N/A)")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //validation - no duplicate SSNs allowed
        [Required]
        [Display(Name = "SSN")]
        public string SSN { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string Email { get; set; }


        //these below aren't required 

        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        //Address-Not required
        [Display(Name = "Address")]
        public string Street { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public string Zipcode { get; set; }


        //Required: DOB
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string DOB { get; set; }


        //page 143-Gender-DropDown LIst -> edit the views/actions
        [Display(Name = "Gender")]
        public string GenderID { get; set; }
        //   public SelectList GenderList { get; set; }


        //not required - highschool-name, city     
        [Display(Name = "Name of High School")]
        public string HighSchoolName { get; set; }


        [Display(Name = "City of High School")]
        public string HighSchoolCity { get; set; }

        //grad date
        [Display(Name = "Graduation Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public string GradDate { get; set; }


        //required - gpa, sat, math, verbal
        //if below 3.0, message ' do not meet minimum qualifications'
        [Required]
        [Display(Name = "Current GPA (4.0 Scale)")]
        [Range(0, 4.0, ErrorMessage = "Value must be between 0 to 4.0")]
        public double GPA { get; set; }

        //sat info
        [Required]
        [Display(Name = "Math (0-800)")]
        [Range(0, 800, ErrorMessage = "Value must be between 0 to 800")]
        public int Math { get; set; }

        [Required]
        [Display(Name = "Verbal (0-800)")]
        [Range(0, 800, ErrorMessage = "Value must be between 0 to 800")]
        public int Verbal { get; set; }
        //if combined scores not > 100, 'do not meet min qualifications'


        //not required
        [Display(Name = "Primary Area of Interest (List of Majors)")]
        public string MajorsInterest { get; set; }


        [Display(Name = "Prospective Enrollment Season (Fall, Spring, Summer)")]
        public string EnrollSeason { get; set; }

        [Display(Name = "Prospective Enrollment Year")]
        public string EnrollYear { get; set; }

        public string Decision { get; set; }


    }
}