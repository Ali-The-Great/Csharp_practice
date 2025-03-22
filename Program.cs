using System;
using System.Collections;
using System.Diagnostics;
using revision;

namespace Revision{
    class Program(){
        static void Main(string[] args){
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
                default:
                    Console.WriteLine("{0} not available.",choice);
                    break;
            }
        }
    }
}