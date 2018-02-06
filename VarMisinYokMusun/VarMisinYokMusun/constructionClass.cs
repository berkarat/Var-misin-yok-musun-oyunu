
using System;
using System.Collections.Generic;
using System.Text;

namespace VarMisinYokMusun
{
    public class constructionClass
    {
        public int SecilenKutu;
        public int StateCounter;
        public int StateCounterLimit;

        public int Sum;
        public int Count;
        public int []kutular;

        public constructionClass(int secilenKutu, int stateCounter, int stateCounterLimit)
        {
            secilenKutu = SecilenKutu;
            stateCounter = StateCounter;
            stateCounterLimit = StateCounterLimit;
        }
        public constructionClass(int sum, int count)
        {
            sum = Sum;
            count = Count;
        }
        public constructionClass(int []Kutular)
        {
            kutular = Kutular;
        }

    }
}
