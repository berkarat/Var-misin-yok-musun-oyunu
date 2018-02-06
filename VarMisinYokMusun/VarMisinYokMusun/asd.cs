using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VarMisinYokMusun
{
    static class asd
    {
        public static int[]  KutuAta()
        {
            int []tempArr ={ 1, 2, 5, 10,50,100,150,200,250,300,400,500,1000,2000,5000,7500,10000,25000,40000,50000,75000,100000,250000,500000 };
            constructionClass kutularim = new constructionClass(tempArr);
            return  Suffle(kutularim.kutular);
        }
        private static int[] Suffle(int []arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int swap = r.Next(arr.Length);
                    if (swap != i)
                    {
                        int temp = arr[i];
                        arr[i] = arr[swap];
                        arr[swap] = temp;
                    }            
            }
            return arr;
        }
        public static int TeklifVer(int[] arr) {
            constructionClass TeklifDeger = new constructionClass(0, 0);
            //int sum=0;
            //int count=0;
            for (int i = 0; i < arr.Length;i++ )
            {
                if (arr[i] != 0)
                {
                    TeklifDeger.Count++;
                    TeklifDeger.Sum+= arr[i];
                }
            }
            return TeklifDeger.Sum / (TeklifDeger.Count + 1);
        }
    }
    
}