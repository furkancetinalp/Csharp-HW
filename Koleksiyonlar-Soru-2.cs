using System;
using System.Collections;
using System.Collections.Generic;
namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            ArrayList list = new ArrayList();
            int sum=0,sum2=0;
            ArrayList list2 = new ArrayList();
            for(int i=0;i<20;i++){
                try{
                    int input = Convert.ToInt32(Console.ReadLine());
                    while(input<0){
                        System.Console.WriteLine("Input cannot be negative!!!");
                        input = Convert.ToInt32(Console.ReadLine());                 
                    }
                    arr[i]=input;   
                }
                catch{
                    System.Console.WriteLine("Only positive and numeric values are allowed!");
                    i--;
                }
            }

            Array.Sort(arr);

            sum2=(arr[0]+arr[1]+arr[2])/3;
            sum=(arr[17]+arr[18]+arr[19])/3;

            System.Console.WriteLine("Avarage of least 3: "+ sum2+": Avarage of biggest 3: "+sum+": Sum of these 2 : "+(sum+sum2));
         
        }       
    }

    
}
