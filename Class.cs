using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_3
{
    public class Class2
    {
        public void Method(Class obj) { obj.Method2(this); }
    }
    public partial class Class
    {
        public string Name;
        public static string Surname;
        public const string Asd = "Asd";
        public readonly string Wasd;

        public string Hello(string name) { return name; }
        public void Method2(Class2 obj) { }
        public void Method3(ref int a, out int b)
        {
            b=a;
        }
        public Class(string Name) 
        {
            this.Name = Name;
        }
        public Class() { }
    }
}
