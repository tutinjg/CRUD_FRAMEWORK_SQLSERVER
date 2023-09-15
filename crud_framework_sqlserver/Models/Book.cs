//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace crud_framework_sqlserver.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Book
    {
        [Display(Name = "#")]
        public int id { get; set; }


        [Display(Name = "Name of the book")]
        public string nameBook { get; set; }


        [Display(Name = "Author of the book")]
        public string author { get; set; }


        [Display(Name = "Release date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:MM/dd/yyyy}")]
        [DataType(DataType.DateTime)]
        public Nullable<System.DateTime> date { get; set; }
    }
}