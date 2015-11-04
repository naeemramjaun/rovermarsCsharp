using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marsrovers
{
    class movement
    {
         public int CodX ; 
            public int CodY;
        
        
        
        public void move(rover rover,plateau plateau)  {
                                   
            
                                    //Call the values x , y , and position thr rover is facing by creating an their objects 
            
                                    int coordinateXrover = rover.getcoodX();
                                    int coordinateYrover = rover.getcoodY();
                                    CodX = coordinateXrover;
                                    CodY = coordinateYrover ;
                                    String roverfacingposition = rover.getposition();
                                    
                                    
                                    //Call the values of the plateau 
                                    int lengthXplateau = plateau.getplateauXlength();
                                    int lengthYplateau = plateau.getplateauYlength();
                                    
                                  
                                    //declare a boolean that will contain TRUE or FALSE to be use in a while loop 
                                    Boolean stop = false ; 
                                    
                                    
                                    loop:while( stop != true){
                                    
                                   
                                    //continue to prompt user to enter command till stop is not equal to true 
                                    Console.WriteLine("Enter your Command");
                                    String command = Console.ReadLine();
                                    
                                    
                                    
                                    //switch statment to check values 1 by 1 
                                    switch(command){
                                                
                                                                  case "M" :        
                                                                  {   if(roverfacingposition.Equals("N")){
                                                                                    if(coordinateYrover < lengthYplateau ){
                                                                                       coordinateYrover++;
                                                                                       }else{
                                                                                       Console.WriteLine("Error out of bound");
                                                                                            }
                                                                  
                                                                                }else if(roverfacingposition.Equals("E")){
                                                                                    if(coordinateXrover < lengthXplateau){
                                                                                            coordinateXrover++;
                                                                                        }else{
                                                                                                Console.WriteLine("Error out of bound");
                                                                                             }
                                                                                
                                                                                 }else if(roverfacingposition.Equals("S")){
                                                                                     if(coordinateYrover > 0 ){
                                                                                         coordinateYrover -- ;
                                                                                        }else{
                                                                                                Console.WriteLine("Error out of bound");
                                                                                             }
                                                                                 }else if(roverfacingposition.Equals("W")){
                                                                                      if(coordinateXrover > 0 )  
                                                                                          coordinateXrover -- ;
                                                                                          }else{
                                                                                               Console.WriteLine("Error out of bound");
                                                                                               }
                                                                                 
                                                                                 break ;
                                                                                }
                                                                  
                                                                  case "L": {            if(roverfacingposition.Equals("N")){
                                                                                        roverfacingposition = "W" ;
                                                                                        }else if(roverfacingposition.Equals("E")){
                                                                                        roverfacingposition = "N" ;
                                                                                        }else if(roverfacingposition.Equals("S")){
                                                                                        roverfacingposition = "E" ;
                                                                                        }else if(roverfacingposition.Equals("W")){
                                                                                        roverfacingposition = "S" ;
                                                                                        }  
                                                                  
                                                                                    break ;
                                                                  }
                                                                      
                                                                  case "R":          {    if(roverfacingposition.Equals("N")){
                                                                                        roverfacingposition = "E" ;
                                                                                        }else if(roverfacingposition.Equals("E")){
                                                                                        roverfacingposition = "S" ;
                                                                                        }else if(roverfacingposition.Equals("S")){
                                                                                        roverfacingposition = "W" ;
                                                                                        }else if(roverfacingposition.Equals("W")){
                                                                                        roverfacingposition = "N" ;
                                                                                        }
  
                                                                                
                                                                                         break ;
                                                                                     }

                                                                  case "Q":
                                                                                 {
                                                                                     stop = true;
                                                                                     goto loop;
                                                                                     
                                                                                 }   
                                                                  
                                                                  default :  Console.WriteLine("Enter valid Command(i.e) Either R or L or M " );
                                                                                 break;
                                                                }
                                    
                                                       Console.WriteLine("rover is @ point (" +coordinateXrover+ ","+coordinateYrover+ " and facing "+roverfacingposition+" )");
                                                                    	 
                                                        
                                                        

                                                        
                                                                         
                                                                        
                                                        }
                                                
                                                }
        
            
    }
}
