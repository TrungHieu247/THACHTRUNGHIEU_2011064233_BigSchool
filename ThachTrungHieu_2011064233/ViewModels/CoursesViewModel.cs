using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThachTrungHieu_2011064233.Models;

namespace ThachTrungHieu_2011064233.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}