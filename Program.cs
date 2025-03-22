using System;
using System.Collections;
using System.Diagnostics;
using revision;

namespace Revision{
    class Program(){
        static void Main(string[] args){
            Console.Write("Enter the number of the module you want to run: ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:
                    HelloWorld.run();
                    break;
                case 2:
                    DataTypes.run();
                    break;
                case 3:
                    Conversion.run();
                    break;
                case 4:
                    Ternary.run();
                    break;
                case 5:
                    Formatting.run();
                    break;
                case 6:
                    ConversionFail.run();
                    break;
                case 7:
                    FizzBuzz.run();
                    break;
                default:
                    Console.WriteLine("{0} not available.",choice);
                    break;
            }
        }
    }
}