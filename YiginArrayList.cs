using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using BTKAkademi.YiginDenemeApp;

namespace BTKAkademi
{
    public class YiginArrayList
    {
        private int top;
        private ArrayList list;
        public int Count { get; }
        public YiginArrayList()
        {
            list = new ArrayList();
            top = -1;
        }
        public void Push(Oge item)
        {
            list.Add(item);
            top++;
        }
        public Oge Pop()
        {
            Oge oge = (Oge)list[top];
            list.RemoveAt(top);
            top--;
            return oge;

        }
        public void Clear()
        {
            list.Clear();
            top = -1;

        }
        public Oge Top()
        {
            return (Oge)list[top];
        }
        public bool StackEmpty()
        {
            if (list == null)
                return true;
            else
                return false;
        }




    }
}
