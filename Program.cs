using System;
using System.Collections.Generic;


namespace DemonGf
{
    class Program
    {
        public static void Main()
    {
        MeetDemon();
        
    }
   public static void MeetDemon(){
           Random rnd = new Random();

        string[] first = new string[]{ "Lum", "Lex", "Lil","Za","Da", "Si","Lo", "Fa"};
        string[] sec = new string[]{ "trix", "lix", "bex", "lysth", "osyth", "lith"};
        Random gen = new Random();
        int age = gen.Next(18, 999);
        string[] gender = new string[]{"Male", "Female", "Non-Binary", "Trans Man", "Trans Woman", "Bigender","Agender", "Genderfluid"};
        string[] Pronouns = new string[]{};

        Console.WriteLine("Name:" + (first[rnd.Next(0, first.Length)])+(sec[rnd.Next(0, sec.Length)]));
        Console.ReadLine();
        System.Console.WriteLine("Age:" + age);
        Console.ReadLine();
        Console.WriteLine("Gender:"+ (gender[rnd.Next(0, gender.Length)]));

        System.Console.WriteLine("Do you want to restart?");

        string sen = (Console.ReadLine());

        if (sen=="yes" && sen=="Yes"){
            

             MeetDemon();

        }  else{
            System.Console.WriteLine("Alright goodbye :D");
            Environment.Exit(0);
        }
 
}
   


   
    }
}