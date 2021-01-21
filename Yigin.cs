using System;
using System.Collections.Generic;
using System.Text;

namespace BTKAkademi.YiginDenemeApp
{
    public class Oge
    {
        private string tanim;
        public string Tanim { get => tanim; set => tanim = value; }

        public Oge(string tanim)
        {
            this.Tanim = tanim;
        }
    }
    
   
    public class Yigin
    {

        Oge[] list;
        int top;
        int N;
        public Yigin (int N)
        {
            this.N = N;
            list = new Oge[N];
            top = -1;
        }
         public Oge Top() => list[top];
        bool yiginDoluMu()
        {
            if (top == N - 1)
                return true;
            else
                return false;
        }  
        bool yiginBosMu()
        {
            if (top == -1)
                return true;
            else
                return false;

        }

        public void Ekle(Oge yeni)
        {
            if (!yiginDoluMu())
            {
                top++;
                list[top] = yeni;
            }

        }
        public Oge Sil()
        {
            if(!yiginBosMu())
            {
                top--;
                return list[top + 1];
            }
            return null;
        }


    }
    
}
