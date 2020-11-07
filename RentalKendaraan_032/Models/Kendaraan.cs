using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_032.Models
{
    public partial class Kendaraan
    {
        public int IdKendaraan { get; set; }

        [Required(ErrorMessage = "Nama Kendaraan tidak boleh kosong")]
        public string NamaKendaraan { get; set; }

        [Required(ErrorMessage = "No Polisi tidak boleh kosong")]
        public string NoPolisi { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "NoSTNK hanya boleh di isi dengan angka")]
        public string NoStnk { get; set; }

        public int? IdJenisKendaraan { get; set; }
        public string Ketersediaan { get; set; }
    }
}
