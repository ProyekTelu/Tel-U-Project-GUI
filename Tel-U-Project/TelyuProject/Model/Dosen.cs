using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using System.IO;

namespace TelyuProject
{
    public class Dosen
    {
        public String NIP { get; set; }
        public String email { get; set; }
        public String first_name { get; set; }
        public String last_name { get; set; }
        public String kode_dosen { get; set; }
        public String gender { get; set; }
        public String prodi { get; set; }
        public String fakultas { get; set; }
        public String phone { get; set; }
        public List<Mahasiswa> requested { get; set; }

    }
}
