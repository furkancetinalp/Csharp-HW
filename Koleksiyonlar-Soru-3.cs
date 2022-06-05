using System;
using System.Collections;
using System.Collections.Generic;
namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> letters = new List<char>{'a','e','ı','i','o','ö','u','ü'};
            string sentence= Console.ReadLine();

            List<char> result = new List<char>();
            foreach(char c in sentence){
                if(letters.Contains(c)){
                    if(!result.Contains(c)){
                        result.Add(c);                      
                    }
                }
            }
            result.Sort();

            foreach(char c in result){
                System.Console.Write(c+",");
            }     
        }       
    }

    
}
