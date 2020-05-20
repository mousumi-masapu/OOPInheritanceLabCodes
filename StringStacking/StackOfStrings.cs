using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StringStacking
{
    public class StackOfStrings
    {
        public List<string> data = new List<string>();
        public void Push(string item)
        {
            data.Add(item);
        }
        public string Pop()
        {
            string item = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return item;

        }
        public string Peek()
        {
            return data[data.Count - 1];
            

        }

        public bool IsEmpty()
        {

            return data.Count == 0;
        }




    }
    }

