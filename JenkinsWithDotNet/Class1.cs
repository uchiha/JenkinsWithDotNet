using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsWithDotNet
{
    public class Program
    {
        private static void Main(String[] args)
        {
            Console.WriteLine(CreateMessage());
        }

        public static String CreateMessage()
        {
            return "Hello JenkinsCI";
        }
    }
}
