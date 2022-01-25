using System;

namespace JewelThief
{
    class Program 
    {
        static void Main(string[] args)
        {
            Safe owner = new SafeOwner();
           
            Safe safe = new Safe();
            
            Locksmith jewelThief = new JewelThief();
            
            jewelThief.OpenSafe(safe, (SafeOwner)owner);
            
            Console.ReadKey(true); 
            
        }
    }
}
