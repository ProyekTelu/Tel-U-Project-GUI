
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using System.IO;
using TelyuProject.Model;

namespace TelyuProject
{
    public class Mahasiswa
    {
        public String NIM { get; set; }
        public String email { get; set; }
        public String first_name { get; set; }
        public String last_name { get; set; }
        public String gender { get; set; }
        public String prodi { get; set; }
        public String fakultas { get; set; }
        public String phone { get; set; }
        public List<Invitation> invitations { get; set; } = new List<Invitation>();
    }
}