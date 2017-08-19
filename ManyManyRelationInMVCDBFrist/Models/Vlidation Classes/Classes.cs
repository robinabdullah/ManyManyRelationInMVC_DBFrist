using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManyManyRelationInMVCDBFrist.Models
{
    [MetadataType(typeof(StudentMetaData))]
    public partial class Student
    {
    }

    [MetadataType(typeof(CourseMetaData))]
    public partial class Cours
    {
    }
}