using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM
{
    class paramClass
    {
        public static int[]  UseParams(int[] list)
        {

            for (int i = 0; i < list.Length; i++)
            {
                
                    list[i]=i;
                
                 
            }
            
            return list;
        }

       

        public int[] asd { get; set; }
    }
}
