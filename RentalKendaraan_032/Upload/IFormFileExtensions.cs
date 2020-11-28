using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RentalKendaraan_032.Upload
{
    public class IFormFileExtensions 
    {
        public static string GetFilename(this IFormFileExtensions file)
        {
            return ContentDispositionHeaderValue.Parse(
                file.ContentDisposition).FileName.ToString().Trim('"');
        }

        public static async Task<MemoryStream> GetFileStream(this IFormFile file)
        {
            MemoryStream filestream = new MemoryStream();
            await file.CopyToAsync(filestream);
            return filestream;
        }

        public static async Task<byte[]> GetFileArray(this IFormFile file)
        {
            MemoryStream filestream = new MemoryStream();
            await file.CopyToAsync(filestream);
            return filestream.ToArray
        }
    }
}