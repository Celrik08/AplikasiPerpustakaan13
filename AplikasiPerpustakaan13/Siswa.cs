using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiPerpustakaan13
{
    public class Siswa
    {
        public string NISN { get; set; }
        public string NamaSiswa { get; set; }

        public override string ToString()
        {
            return $"{NISN} - {NamaSiswa}";
        }
    }
}
