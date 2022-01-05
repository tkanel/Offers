using Microsoft.AspNetCore.Hosting;
using System.IO;


namespace Offers
{
    public class UploadFiles
    {

       
        public void CreateFolder(string year,string uploadsFolder)
        {
                       

            if (!Directory.Exists(uploadsFolder))
            {

                Directory.CreateDirectory(uploadsFolder);

            }


        }


        public void UploadFile(string filename, string folder)
        {
                       

            if (filename != null)
            {
                //copy file to Attachments folder


                string filePath = Path.Combine(folder, filename);

                var ifExists = System.IO.File.Exists(filePath);


                if (!ifExists)
                {

                    File.Copy(filePath, filePath, true);


                }


            }

        }
    }
}
