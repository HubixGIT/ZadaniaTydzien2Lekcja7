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
//Console.WriteLine("exercise 7\n");

//Console.WriteLine("Type in 3 integer numbers");
//string m = Console.ReadLine();
//int num1 = 0;
//Int32.TryParse(m, out num1);
//string s = Console.ReadLine();
//int num2 = 0;
//Int32.TryParse(s, out num2);
//string d = Console.ReadLine();
//int num3 = 0;
//Int32.TryParse(d, out num3);

//if(num1 == num2 && num1 == num3)
//{
//    Console.WriteLine("All the numbers are the same");
//}
//else if(num1 == num2)
//{
//    if(num1 > num3)
//    {
//        Console.WriteLine("Number 1 and 2: \"" + num1 + "\" are equal and are greater than \"" + num3 + "\"");
//    }
//    else
//    {
//        Console.WriteLine("Number 3: \"" + num3 + "\" is the largest number");
//    }
//}
//else if (num1 == num3)
//{
//    if (num1 > num2)
//    {
//        Console.WriteLine("Number 1 and 3: \"" + num1 + "\" are equal and are greater than \"" + num2 + "\"");
//    }
//    else
//    {
//        Console.WriteLine("Number 2: \"" + num2 + "\" is the largest number");
//    }
//}
//else if (num2 == num3)
//{
//    if (num2 > num1)
//    {
//        Console.WriteLine("Number 2 and 3: \"" + num2 + "\" are equal and are greater than \"" + num1 + "\"");
//    }
//    else
//    {
//        Console.WriteLine("Number 1: \"" + num1 + "\" is the largest number");
//    }
//}
//else if(num1 > num2 && num1 > num3)
//{
//    Console.WriteLine("Number 1: \"" + num1 + "\" is the largest number");
//}
//else if(num2 > num1 && num2 > num3)
//{
//    Console.WriteLine("Number 2: \"" + num2 + "\" is the largest number");
//}
//else if (num3 > num1 && num3 > num2)
//{
//    Console.WriteLine("Number 3: \"" + num3 + "\" is the largest number");
//}
//****************************************************************************************************
//Console.WriteLine("exercise 8\n");

//Console.WriteLine("Please type in you're A level test results from the following subjects: ");
//Console.WriteLine("Maths: ");
//string math = Console.ReadLine();
//Console.WriteLine("Physics: ");
//string physics = Console.ReadLine();
//Console.WriteLine("Chemistry: ");
//string chemistry = Console.ReadLine();
//int m;
//int p;
//int c;
//m = Convert.ToInt32(math);
//p = Convert.ToInt32(physics);
//c = Convert.ToInt32(chemistry);


//if ( (m + p + c) >= 180 || m + p >= 150 || m + c >= 150)
//{
//    Console.WriteLine("You got in to university.");
//}
//else
//{
//    Console.WriteLine("Sorry, your results aren't sufficient enough.");
//}