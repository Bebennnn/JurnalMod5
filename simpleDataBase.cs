using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_103022330122
{
    public class simpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDate;

        public simpleDataBase()
        {
            storedData = new List<T>();
            inputDate = new List<DateTime>();
        }
        public void addNewData(T data)
        {
            storedData.Add(data);
            inputDate.Add(DateTime.Now);
        }

        public void printAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data   {i + 1} berisi:  {storedData[i]} yang disimpan pada waktu {inputDate[i]}");
            }

        }
    }
}
