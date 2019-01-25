using System;

namespace final_app

{
    class Program
    {
        static void Main(string[] args)
        {                                            
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hi {name}, Enter your age: ");            
            int age = Convert.ToInt32(Console.ReadLine());      
            bool gender = false;
            char t;
            while(name != ""){      
            switch(age)
            {
                case 18:
                    Console.WriteLine("You have to wait one year");
                    break;
                case 19:
                    Console.WriteLine("You are eligible");
                    break;
                case 17:
                    Console.WriteLine("You are not eligible");
                    break;
                default:
                    Console.WriteLine("If you are <18 enter 17; If you are =18 enter 18; If you are >18 enter 19");
                    return;
            } 
            break;           
            }     
            Console.WriteLine("Press M if you are male. Else enter any key.");
            t=Convert.ToChar(Console.ReadLine());
            if(t=='M'){
                gender=true;
            }
            while(age ==18 || age ==19 || age ==17)                        
            {
                double tax = 0.0;
                Console.WriteLine("Enter your income: ");
                double income = Convert.ToDouble(Console.ReadLine());            
                if(income  < 20000){
                    tax = income - (income*0.2);
                 }
                else if(income >=20000 && income <= 50000){
                    tax = income - (income * 0.5);
                }
                else{
                 tax = income - (income * 0.8);
                 }            
                Console.WriteLine("your Name is {0}",name);//print name
                Console.WriteLine("your age is {0}",age);//print age
                Console.WriteLine("Gender:\t"+(gender?"Male":"Female"));//print gender
                Console.WriteLine($"You should pay {tax}");
                Console.WriteLine();
                break;
            }

            Console.WriteLine("Enter y if paid");
            
        }   
    }
}
