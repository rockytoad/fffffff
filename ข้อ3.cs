using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode;
            Console.WriteLine("input mode : ");
            mode = Console.ReadLine();
            int i = 1;
            
            while (i != 0)
            {
                float flimblackwidth;
                Console.WriteLine("input blackwidth : ");
                flimblackwidth = float.Parse(Console.ReadLine());
                if (flimblackwidth > 0)
                {
                    double flength, fov;
                    flength = float.Parse(Console.ReadLine());
                    fov = float.Parse(Console.ReadLine());
                    if (mode == "flength")
                    {
                        Console.WriteLine("input length");
                        if (flength > 0)
                        {

                            fov = 2 * Math.Atan(flimblackwidth / (2 * flength));
                            Console.WriteLine("fLength = {0}, fov = {1}", flength, fov);
                            break;

                        }
                        else
                        {
                            Console.WriteLine("invaid flenght inputagain");
                        }

                    }
                    else
                    {
                        Console.WriteLine("input fov");
                        if (fov > 0.1 && fov < 6.28)
                        {
                            flength = flimblackwidth / (2 * Math.Tan(fov / 2));
                            Console.WriteLine("fLength = {0}, fov = {1}", flength, fov);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("invaid fov inputagain");
                        } 
                    } 

                    
                  
                }
                else
                {
                    Console.WriteLine("invaid"); 
                }
                break;
            }
            Console.ReadLine();
            
            


        }
    }
}
