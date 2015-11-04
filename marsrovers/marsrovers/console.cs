using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marsrovers
{
    class console
    {

         public static void Main(String [] args) {
                    
        
                                //Creating Objects from class
                                rover rover = new rover() ;
                                plateau plateau = new plateau () ; 
                                movement movement = new movement () ;
                                constant constant = new constant() ;

                              
                                

                                //user input plateau size X
                                while(true){
                                    Console.WriteLine(constant.plateauXlength);
                                try{
                                    int plateausizeX = int.Parse(Console.ReadLine());
                                    plateau.setplateauXlength(plateausizeX);
                                    break;
                                }catch(FormatException ){
                                    Console.WriteLine("Enter a valid Plateau length for its X Length");
                            }
                        }
                                
                                
                              
                                

                                //user input plateau size Y
                                while(true){
                                   Console.WriteLine(constant.plateauYlength);
                                try{
                                    int plateausizeY = int.Parse(Console.ReadLine());
                                    plateau.setplateauYlength(plateausizeY);
                                    break;
                                }catch(FormatException  ){
                                    Console.WriteLine("Enter a valid Plateau length for its Y Length");
                            }
                        }                              
                                
                              
                                
                              do{  

                                //user input coordinate X of rover
                                while(true){
                                    Console.WriteLine(constant.messageroverX);
                                try{
                                    int xaxis = int.Parse(Console.ReadLine());
                                    if(xaxis == movement.CodX){
                                        Console.WriteLine("a Rover is already in the position");
                                    }else{
                                        
                                    if(xaxis > plateau.getplateauXlength() ){
                                        Console.WriteLine("Out of bound");
                                    }else{
                                        
                                       
                                    rover.setcoodX(xaxis);
                                    break;
                                    }}
                                }catch(FormatException  ){
                                    Console.WriteLine("Invalid X-Coordinate");
                                }
                            }
                    
                    
                                




                                //user input from user for Coordinate Y for the rover
                                while(true){
                                    Console.WriteLine(constant.messageroverY); 
                                try{
                                    int yaxis = int.Parse(Console.ReadLine());
                                    if(yaxis == movement.CodY){
                                      Console.WriteLine("a Rover is already in the position");
                                    }else{
                                    
                                     if(yaxis > plateau.getplateauYlength() ){
                                     Console.WriteLine("Out of bound");
                                     }else{
                                    rover.setcoodY(yaxis);
                                    break;
                                     }}
                                }catch(FormatException  ){
                                    Console.WriteLine("Invalid Y-Coordinate");
                            }
                        }
                     
                  
                    

                                
                                
                                //user input where the rover is facing 
                                while(true){
                          Console.WriteLine(constant.roverdirection); 
                                    String roverfacing = Console.ReadLine();
                                    if( roverfacing.Equals("N")||roverfacing.Equals("S")||roverfacing.Equals("E")||roverfacing.Equals("W")){
                                    rover.setposition(roverfacing);
                                    break;
                                }else{
                                   Console.WriteLine("Enter Valid Position (i.e) N,S,E,W");
                            }
                        }
         
                                
                                //rover movement on the plateau
                                movement.move(rover, plateau);
                                
                                
                                
                                //wish to send another rover 
                                Console.WriteLine("Do you want to send another rover on Mars? (yes/no)");
                              }while(Console.ReadLine().Equals("yes"));
                                
                            
                    
                  }


    }
}
