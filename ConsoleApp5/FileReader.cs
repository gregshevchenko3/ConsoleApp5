using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class FileReader
    {
        static public string[] ReadTxtFile(string pathToFile)
        {
            if (File.Exists(pathToFile))
            {
                if (Path.GetExtension(pathToFile) == ".txt")
                {
                    return File.ReadAllLines(pathToFile);
                }
                else
                {
                    throw new Exception("Incorrect File Extention");
                }

            }
            else
            {
                throw new FileNotFoundException("File not Found " + pathToFile);
            }
        }
        static public string ReadDocFile(string path)
        {
            return "";
        }
    }
}
