using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelyuProject.Model
{
    public static class UserSession<T>
    {
        public static T currentUser { get; set; }
    }

}
