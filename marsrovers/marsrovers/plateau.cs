using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marsrovers
{
    class plateau
    {
        int plateauXcood;
        int plateauYcood;




        public void setplateauXlength(int x)
        {
            this.plateauXcood = x;
        }


        public int getplateauXlength()
        {
          
            return plateauXcood;
        }


        public void setplateauYlength(int y)
        {
            this.plateauYcood = y;
        }


        public int getplateauYlength()
        {
            return plateauYcood;
        }
    
    }
}
