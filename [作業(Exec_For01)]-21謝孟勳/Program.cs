using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業_Exec_For01___21謝孟勳
{
    //倒星形三角形
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = string.Empty;
            
            for (int i = 10; i > 0; i--)
            {
                string row = new string('*', i);
                Console.WriteLine(row);
            }
            
            
        }
    }
}
