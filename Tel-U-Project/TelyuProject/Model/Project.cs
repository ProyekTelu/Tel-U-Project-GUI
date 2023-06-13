using System;
using System.Collections.Generic;

namespace TelyuProject
{
    public class Project
    {
            public string Title { get; set; }
            public string Lecturer { get; set; }
            public string LecturerNip { get; set; }
            public string Description { get; set; }
            public List<string> Prodi { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public bool IsDone { get; set; }
            public bool IsOpen { get; set; }
            public List<Mahasiswa> ListMahasiswa { get; set; }
            public int quota { get; set; }

            public string linkGroup { get; set; }


        }



}