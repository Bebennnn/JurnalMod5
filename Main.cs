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
            simpleDataBase<int> simple = new simpleDataBase<int>();
            simple.addNewData(12);
            simple.addNewData(13);
            simple.addNewData(14);

            simple.printAllData();
        }
    }


}
