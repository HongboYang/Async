using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YHB.Async;
using System.IO;
namespace YHB.AsyncTest
{
    class Program
    {
        public static async WITask<string> ReadConfig()
        {
            FileStream fs = File.OpenRead(@"D:\99_Temp\file.txt");
            byte[] buff = new byte[fs.Length];
            await fs.ReadAsync(buff, 0, buff.Length);
            string str = Encoding.UTF8.GetString(buff, 0, buff.Length);
            Console.WriteLine(str);
            return str;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Start");
            ReadConfig();
            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
