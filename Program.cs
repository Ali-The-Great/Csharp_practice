using System;
using System.Collections;
using System.Diagnostics;
using revision;

Console.Write("Enter the number of the module you want to run: ");
int choice;
if (int.TryParse(Console.ReadLine(), out choice)){
    switch (choice)
    {
        case 1:
            HelloWorld.Run();
            break;
        case 2:
            DataTypes.Run();
            break;
        case 3:
            Conversion.Run();
            break;
        case 4:
            Ternary.Run();
            break;
        case 5:
            Formatting.Run();
            break;
        case 6:
            ConversionFail.Run();
            break;
        case 7:
            FizzBuzz.Run();
            break;
        case 8:
            Verbatim.Run();
            break;
        case 9:
            StringConcat.Run();
            break;
        case 10:
            EmptyStringCompare.Run();
            break;
        case 11:
            StringLooping.Run();
            break;
        case 12:
            PrintInReverse.Run();
            break;
        case 13:
            PasswordChecker.Run();
            break;
        case 14:
            ArrayIntro.Run();
            break;
        case 15:
            ListIntro.Run();
            break;
        case 16:
            Dictintro.Run();
            break;
        case 17:
            EvenOddSplit.Run();
            break;
        case 18:
            MultipleArray.Run();
            break;
        case 19:
            OptionalParameters.Run();
            break;
        case 20:
            PassByRef.Run();
            break;
        case 21:
            AreaTriangle.Run();
            break;
        case 22:
            ArrayIntSum.Run();
            break;
        case 23:
            ExceptionHandling.Run();
            break;
        case 24:
            ClassIntro.Run();
            break;
        case 25:
            AbstractIntro.Run();
            break;
        case 26:
            OpeOverload.Run();
            break;
        case 27:
            StackIntro.Run();
            break;
        case 28:
            QueueIntro.Run();
            break;
        case 29:
            RandomStuff.Run();
            break;
        case 30:
            await AwaitForeach.Run();
            break;
        case 31:
            ConstructorsIntro.Run();
            break;
        case 32:
            InheritenceIntro.Run();
            break;
        case 33:
            InterfaceIntro.Run();
            break;
        case 34:
            MultipleInheritance.Run();
            break;
        default:
            Console.WriteLine("{0} not available.", choice);
            break;
    }
}
else{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}