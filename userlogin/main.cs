using System;

namespace Application
{
    class mainclass
    {
        static void Main (string[] args)  
        {
            
            while(true){
                Console.WriteLine("         ----------[WElCOME]-------");
                Console.WriteLine("press 1 to login :");
                Console.WriteLine("press 2 to register :");
                Console.WriteLine("Press 3 to Exit . ");
                int num = Convert.ToInt32(Console.ReadLine());


                if(num == 1)
                {       
                       
                        Loginclass logobj = new Loginclass();
                        logobj.login();
                }
                else if (num == 2)
                {
                   

                    Registerclass regobj = new Registerclass();
                    
                        regobj.register();
            

                }
                else if (num == 3)
                {
                    break;
                }
                else
                {
                        Console.WriteLine("Invalid Option ... !");
                }


            }


            
            

            
        }
    }
}