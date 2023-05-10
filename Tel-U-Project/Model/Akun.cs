using System.Collections.Generic;
using System;

namespace Model
{
    public class Akun<T>
    {
        private List<T> data { get; set; }
        private List<String> password { get; set; }

        public Akun()
        {
            data = new List<T>();
            password = new List<string>();
        }

        public void AddData(T item, string password)
        {
            data.Add(item);
            this.password.Add(password);
        }

        public List<T> GetData()
        {
            return data;
        }

        public List<string> GetPasswords()
        {
            return password;
        }
    }
}
