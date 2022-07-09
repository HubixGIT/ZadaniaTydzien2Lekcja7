//Console.WriteLine("Exercise 1");
//int a = 5;
//int b = 5;

//if(a == b)
//{
//    Console.WriteLine(a + " and " + b + " are equal to each other.");
//}
//else
//{
//    Console.WriteLine(a + " and " + b + "aren't equal to each other.");
//}
////****************************************************************************************************
//Console.WriteLine("Exercise 2\n");

//Console.WriteLine("Please type in an integer number.");
//string x = Console.ReadLine();
//int number = 0;
//Int32.TryParse(x, out number);
//number = number % 2;

//if(number == 0)
//{
//    Console.WriteLine(x + " is an even number.");
//}
//else
//{
//    Console.WriteLine(x + " is an odd number.");
//}
////****************************************************************************************************
//Console.WriteLine("Exercise 3\n");

//Console.WriteLine("Please type in a number.");
//string y = Console.ReadLine();
//float num = 0;
//float.TryParse(y, out num);
//if(num < 0)
//{
//    Console.WriteLine("Negative number");
//}
//else if (num > 0)
//{
//    Console.WriteLine("Positive number");
//}
//else
//{
//    Console.WriteLine("Number is 0");
//}
////****************************************************************************************************
//Console.WriteLine("exercise 4\n");

//Console.WriteLine("Type in a year.");
//string v = Console.ReadLine();
//int year = 0;
//Int32.TryParse(x, out year);

//if(year % 4 == 0)
//{
//    Console.WriteLine("Leap year");
//}
//else
//{
//    Console.WriteLine("Not a leap year");
//}
////****************************************************************************************************
//Console.WriteLine("exercise 5\n");
//Console.WriteLine("Type in your age: ");
//string c = Console.ReadLine();
//int age = 0;
//Int32.TryParse(c, out age);
//if(age >= 21)
//{
//    Console.WriteLine("You can become a Member of Parlament or Prime minister");
//    if(age >= 30)
//    {
//        Console.WriteLine("or Senator");
//        if(age >= 35)
//        {
//            Console.WriteLine("or President");
//        }
//    }
//}
//else
//{
//    Console.WriteLine("You are too young");
//}
////****************************************************************************************************
//Console.WriteLine("exercise 6\n");

//Console.WriteLine("Put in your height in cm");
//string n = Console.ReadLine();
//int height = 0;
//Int32.TryParse(n, out height);
//if (n == "")
//{
//    Console.WriteLine("You are an atom");
//}
//else
//{
//    if (height <= 140)
//    {
//        Console.WriteLine("Dwarf");
//    }
//    else if (height > 140 && height < 180)
//    {
//        Console.WriteLine("Normal");
//    }
//    else
//    {
//        Console.WriteLine("Giant");
//    }
//}
////****************************************************************************************************
Console.WriteLine("exercise 7\n");

Console.WriteLine("Put in your height in cm");
string m = Console.ReadLine();
int num1 = 0;
Int32.TryParse(m, out num1);
string s = Console.ReadLine();
int num2 = 0;
Int32.TryParse(s out num2);
string d = Console.ReadLine();
int num3 = 0;
Int32.TryParse(d, out num3);