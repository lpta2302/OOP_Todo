using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    public class TaskFilter
    {
        
        public static List<Task> ArrangeByType()
        {
            List<Task> list = new List<Task>();
            foreach (Task t in GlobalData.CurrentTasks)
            {
                if(t is ShortTerm)
                {
                    list.Add(t);
                }
            }
            return list;
        }
        //public List<Task> ArrangeByImportance()
        //{

        //}
        //public List<Task> ArrangeByCompletion()
        //{

        //}
    }
}
