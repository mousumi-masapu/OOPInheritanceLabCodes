using System;
using System.Collections.Generic;
using System.Text;

namespace ReusingClass
{
    class RandomList : List<string>
    {
        public string RandomString()
        {
            Random rand = new Random();
            int index = rand.Next(0, Count);
            String element=this[index];
            this.RemoveAt(index);
            return element;
            
        }
    }
}
