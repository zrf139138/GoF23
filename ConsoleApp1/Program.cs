using Masuit.Tools.Files;
using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream fs = new FileStream(@"D:\boot.vmdk", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            {
                //fs.CopyToFile(@"D:\1.bak");//同步复制大文件
                fs.CopyToFileAsync(@"D:\1.bak");//异步复制大文件
                string md5 = fs.GetFileMD5();//异步获取文件的MD5
            }

            Console.WriteLine("Hello World!");
        }
    }
}
