using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _496427_Luthfi_ResponsiJuniorProject
{
    public class Karyawan
    {
        private string nama;
        private string id_karyawan;
        private int id_departemen;
        private string nama_departemen;
        private string nama_jabatan;
        private int id_jabatan;

        // Data Encapsulation
        public string _nama { get => nama; set => nama = value; }
        public string _id_karyawan { get => id_karyawan; set => id_karyawan = value; }
        public int _id_departemen { get => id_departemen; set => id_departemen = value; }
        public string _nama_departemen { get => nama_departemen; set => nama_departemen = value; }
        public string _nama_jabatan { get => nama_jabatan; set => nama_jabatan = value; }
        public int _id_jabatan { get => id_jabatan; set => id_jabatan = value; }

        // Data Abstraction
        public Karyawan(string nama, string id_karyawan, int id_departemen, string nama_departemen, string nama_jabatan, int id_jabatan)
        {
            _nama = nama;
            _id_karyawan = id_karyawan;
            _id_departemen = id_departemen;
            _nama_departemen = nama_departemen;
            _nama_jabatan = nama_jabatan;
            _id_jabatan = id_jabatan;
        }
    }
}
