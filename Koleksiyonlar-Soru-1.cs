using System;
using System.Collections;
using System.Collections.Generic;
namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
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
                    int index=0;
                    for(int j=2;j<input;j++){
                        if(input%j==0){
                            list.Add(input);
                            sum+=input;
                            index=1;
                            break;
                        }
                    }
                    if(index==0){
                        list2.Add(input);
                        sum2+=input;
                    }    
                }
                catch{
                    System.Console.WriteLine("Only positive and numeric values are allowed!");
                    i--;
                }
            }

            list.Sort();
            list.Reverse();
            list2.Sort();
            list2.Reverse();

            foreach(int i in list){
                Console.Write(i+" ");
            }
            System.Console.WriteLine("\n");
            foreach(int i in list2){
                Console.Write(i+" ");
            }
            System.Console.WriteLine("\n");

            System.Console.WriteLine("list: "+list.Count+" list2: "+list2.Count);
            System.Console.WriteLine("list: "+sum/list.Count+" list2: "+sum2/list2.Count);

            
        }       
    }

    
}
