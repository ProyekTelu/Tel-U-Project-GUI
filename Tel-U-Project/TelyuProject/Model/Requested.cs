using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelyuProject
{
    public class Requested
    {
        public String student_name { get; set; }
        public String lecturer_name { get; set; }
        public String email { get; set; }
        public String phone { get; set; }
        public String notes { get; set; }
        public String cv_directory { get; set; }
        public String projectName { get; set; }
        public Mahasiswa Mahasiswa { get; set; }
    }
}
