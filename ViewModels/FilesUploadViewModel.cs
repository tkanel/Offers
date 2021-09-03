using Offers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Offers.ViewModels
{
    public class FilesUploadViewModel
    {
        public IEnumerable<FileName> FileNames { get; set; }
        public List<string> UploadedFiles { get; set; }

        public string Filename { get; set; }

        public bool isInserted { get; set; }

    }
}
