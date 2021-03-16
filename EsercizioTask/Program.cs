using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;


namespace EsercizioTask
{
    public class Program
    {
        
        int NumeriTotali;
        public Program(int n)
        {
            NumeriTotali = n;
        }
        static void task()
        {
            Task<int> t1 = Task.Factory.StartNew(() => StampaNumeri());
        }
        public int StampaNumeri()
        {          
            for (int i = 0; i <= 200000000; i = i + 2)
            {
                NumeriTotali++;
            }
            return NumeriTotali;
        }
    }
}
