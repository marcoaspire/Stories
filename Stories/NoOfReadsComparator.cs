using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story5
{
    class NoOfReadsComparator : IComparer<Story>
    {
        int IComparer<Story>.Compare(Story story1, Story story2)
        {
            if (story1.NoOfReads > story2.NoOfReads)
            {
                
                return 1;
            }
            else if (story1.NoOfReads < story2.NoOfReads)
            {  return -1; }
            else
                return 0;
        }
        
    }
}
