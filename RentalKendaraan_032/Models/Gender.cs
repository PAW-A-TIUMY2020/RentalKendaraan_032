using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_032.Models
{
    public partial class Gender
    {
        public int IdGender { get; set; }

        [Required(ErrorMessage = 'Nama Gender tidak boleh kosong')]
        public string NamaGender { get; set; }
    } 
}
