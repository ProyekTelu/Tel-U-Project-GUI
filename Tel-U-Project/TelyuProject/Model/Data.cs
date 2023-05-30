
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelyuProject
{
    internal static class Data
    {
        public static Akun<Mahasiswa> mahasiswaList = new Akun<Mahasiswa>();
        public static Akun<Dosen> dosenList = new Akun<Dosen>();
        public static List<Project> projectList = new List<Project>();
        public static List<Requested> requestList = new List<Requested>();
    }
}
