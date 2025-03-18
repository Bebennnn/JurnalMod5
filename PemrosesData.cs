using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_103022330122
{
    public class PemrosesData
    {
        
        public void DapatkanNilaiTerbesar<T> (T nilai1, T nilai2, T nilai3)
        {
            dynamic A = (dynamic)nilai1;
            dynamic B = (dynamic)nilai2;
            dynamic C = (dynamic)nilai3;
            dynamic max = A;

            if (max < B) 
            {
               max = B;
            }

            if (max < C)
            {
                max = C;
            }
            Console.WriteLine ("nilai max: " + max);
        }
    }
}
