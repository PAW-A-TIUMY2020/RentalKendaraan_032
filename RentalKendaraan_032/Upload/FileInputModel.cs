using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RentalKendaraan_032.Upload
{
    public class FileInputModel 
    {
        public IFormFile FileToUpload { get; set; }

    }
}