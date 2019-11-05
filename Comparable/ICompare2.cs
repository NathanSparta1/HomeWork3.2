using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable
{
    
       interface ICompareByName:ICompareByLength
    { 
        int CompareByName();
    }
    interface ICompareByLength
    {
        int CompareByLength();
    }


    }

