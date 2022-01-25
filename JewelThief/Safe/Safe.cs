﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JewelThief
{
    class Safe 
    {
        private  string contents = "precious jewels";
        private  string safeCombination = "12345";

        public string Open(string combination)
        {
            if (combination == this.safeCombination) return this.contents;
            return "";
        }

        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.Combination = this.safeCombination;
        }
    }

}
