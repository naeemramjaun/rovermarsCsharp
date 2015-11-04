using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marsrovers
{
   public class rover
    {
        // X and Y are cooordinates 
        public int x;
        public int y;
        public String face;




        //setting X coordinate for rover 
        public void setcoodX(int x)
        {
            this.x = x;
        }

        //setting Y coordinate fot rover
        public void setcoodY(int y)
        {
            this.y = y;
        }

        //getting value of X coordiante of the rover
        public int getcoodX()
        {
            return x;
        }

        //getting the value of the Y coordinate of the rover
        public int getcoodY()
        {
            return y;
        }


        //setting position of the rover 
        public void setposition(String x)
        {
            this.face = x;
        }


        //getting position of the rover 
        public String getposition()
        {
            return this.face;

        }
                            
                            
                            
                            
                            
    }
}
