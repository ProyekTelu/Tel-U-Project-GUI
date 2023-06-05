using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using System.IO;

namespace TelyuProject
{
    public class Akun<T>
    {
        public List<T> data { get; set; }
        public List<String> password { get; set; }


    }
}
