using System;
using System.Collections.Generic;
using System.Text;

namespace JewelThief
{
    class SafeOwner : Safe
    {
        private string valuables = "";
        public void ReceiveContents(string safeContents)
        {
            this.valuables = safeContents;
            Console.WriteLine($"Thank you for returning my {valuables}!");
        }
    }
}
