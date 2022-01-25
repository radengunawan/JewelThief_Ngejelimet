using System;
using System.Collections.Generic;
using System.Text;

namespace JewelThief
{
    class JewelThief : Locksmith
    {
        private string stolenJewels;
        protected override void ReturnContents(string safeContents, SafeOwner owner) // owner nggak kepake karena override
        //protected override void ReturnContents(string safeContents)
        {
            this.stolenJewels = safeContents;
            //this.stolenJewels = owner.;
            Console.WriteLine($"I'm stealing the jewels! I stole: {stolenJewels}");
        }
    }
}
