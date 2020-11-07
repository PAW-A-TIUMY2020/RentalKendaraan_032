using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_032.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }
        public int IdCustomer { get; set; }
        [Required(ErrorMessage = "Nama Customer tidak boleh kosong")]
        public string NamaCustomer { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "nik hanya boleh di isi dengan angka")]
        public string Nik { get; set; }

        [Required(ErrorMessage = "Alamat wajib diisi")]
        public string Alamat { get; set; }

        [MinLength(11, ErrorMessage = "No hp tidak boleh kurang dari 10 angka")]
        [MaxLength(13, ErrorMessage = "No hp tidak boleh dari 13 angka")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "No hp hanya boleh di isi dengan angka")]
        [Required(ErrorMessage = "No hp wajib diisi")]
        public string NoHp { get; set; }

        public int? IdGender { get; set; }
        public object Peminjaman { get; }
    }
}
