using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Offers
{
    public class ReadDirectoryFiles
    {
        public void EnumerateFiles()
        {

            string sourceDirectory = @"C:\current";
            string archiveDirectory = @"C:\archive";

            var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.txt", SearchOption.AllDirectories);

            foreach (string currentFile in txtFiles)
            {
                string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                Directory.Move(currentFile, Path.Combine(archiveDirectory, fileName));
            }



        }





    }
}
