using System;
using System.Collections.Generic;
using System.Text;

namespace JewelThief
{
    class Locksmith 
    {
        public string Combination { private get; set; }

        public void OpenSafe(Safe safe, SafeOwner owner)
        {
            safe.PickLock(this);
            string safeContents = safe.Open(this.Combination);
            ReturnContents(safeContents, owner);
        }

        

        protected virtual void ReturnContents(string safeContents, SafeOwner owner)
        {
            owner.ReceiveContents(safeContents);
        }
    }
}
