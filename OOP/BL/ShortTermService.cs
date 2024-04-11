using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class ShortTermService
    {
        public int CountShortTerm()
        {
            int count = 0;
            foreach ( ShortTerm shortTerm in GlobalData.CurrentTasks)
            {
                if ( shortTerm is ShortTerm)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
