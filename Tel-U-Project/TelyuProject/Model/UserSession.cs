using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelyuProject.Model
{
    public static class UserSession
    {
        public static Mahasiswa currentMhsUser { get; set; }
        public static Dosen currentDosenUser { get; set; }
    }

}
