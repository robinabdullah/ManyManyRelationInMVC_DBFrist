using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManyManyRelationInMVCDBFrist.Models
{
    public class StudentMetaData
    {
        [Required ,DataType(DataType.Text)]
        public string Name { get; set; }
        [Required ,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required ,DataType(DataType.Date)]
        public Nullable<System.DateTime> DOB { get; set; }
    }
    public class CourseMetaData
    {
        [Required ,DataType(DataType.Text)]
        public string Name { get; set; }
        [Required ,Range(1,6)]
        public int Credit { get; set; }
    }
}