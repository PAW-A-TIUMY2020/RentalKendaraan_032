using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RentalKendaraan_032.Upload
{
    public class FileViewsModel 
    {
        public class FileDetails
        {
            public string Name { get; set; }
            public string Path { get; set; }
        }

        public class FilesViewModel
        {
            public List<FileDetails> Files { get; set; }
                = new List<FileDetails>();
        }
    }
}