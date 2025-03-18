using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_103022330122
{

    internal class program
    {
        public static void Main(string[] args)
        {
            PemrosesData pemroses = new PemrosesData();
            pemroses.DapatkanNilaiTerbesar<float>(12, 24, 56);
        }
    }


}
