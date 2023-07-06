using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class PersonContactfile
    {
        public void FileExistOrNot(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("file Exist");
            }
            else
            {
                Console.WriteLine("FileNotExist");
            }
        }
    }
}
