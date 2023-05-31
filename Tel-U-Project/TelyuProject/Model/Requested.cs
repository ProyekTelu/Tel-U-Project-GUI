using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelyuProject
{
    public class Requested
    {
        public String lecturerName { get; set; }
        public String lecturerNip { get; set; }
        public String notes { get; set; }
        public String cvDirectory { get; set; }
        public String projectName { get; set; }
        public Mahasiswa Mahasiswa { get; set; }
    }
}
