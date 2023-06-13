using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelyuProject.Model
{
    public class Invitation
    {
        public String project;
        public String dosen;
        public String description;

        public Invitation(String project, String dosen, String description)
        {
            this.project = project;
            this.dosen = dosen;
            this.description = description;
        }
    }
}
