using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiPerpustakaan13
{
    internal class Buku
    {
        public string ISBN { get; set; }
        public string JudulBuku { get; set; }

        public override string ToString()
        {
            return $"{ISBN} - {JudulBuku}";
        }
    }
}
