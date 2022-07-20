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
//****************************************************************************************************
//Console.WriteLine("exercise 9\n");

//Console.WriteLine("Please put in the current tempature: ");
//string temp = Console.ReadLine();
//int t;
//t = Convert.ToInt32(temp);

//if(t < 0)
//{
//    Console.WriteLine("It's freezing");
//}
//else if(t >= 0 && t < 10)
//{
//    Console.WriteLine("It's cold");
//}
//else if (t >= 10 && t < 20)
//{
//    Console.WriteLine("It's chilly");
//}
//else if (t >= 20 && t < 30)
//{
//    Console.WriteLine("It's ok");
//}
//else if (t >= 30 && t < 40)
//{
//    Console.WriteLine("It's getting hot");
//}
//else if (t >= 40)
//{
//    Console.WriteLine("It's boiling hot at this point");
//}
//****************************************************************************************************
//Console.WriteLine("exercise 10\n");
//int a;
//int b;
//int c;
//Console.WriteLine("Please enter 3 sides of a triangle: ");
//string aString = Console.ReadLine();
//a = Convert.ToInt32(aString);
//string bString = Console.ReadLine();
//b = Convert.ToInt32(bString);
//string cString = Console.ReadLine();
//c = Convert.ToInt32(cString);

//if(a > b && a > c)
//{
//    if(a < b + c)
//    {
//        Console.WriteLine("A triangle can be made");
//    }
//    else
//    {
//        Console.WriteLine("A triangle can't be made");
//    }
//}
//else if(b > a && b > c)
//{
//    if (b < a + c)
//    {
//        Console.WriteLine("A triangle can be made");
//    }
//    else
//    {
//        Console.WriteLine("A triangle can't be made");
//    }
//}
//else if(c > a && c > b)
//{
//    if (c < b + a)
//    {
//        Console.WriteLine("A triangle can be made");
//    }
//    else
//    {
//        Console.WriteLine("A triangle can't be made");
//    }
//}
//else
//{
//    Console.WriteLine("A triangle can't be made");
//}
//****************************************************************************************************
//Console.WriteLine("exercise 11\n");

//Console.WriteLine("Wpisz jaka ocene dostałeś od 1-6");
//string grade = Console.ReadLine();

//switch(grade)
//{
//    case "1":
//        Console.WriteLine("Niedostateczny");
//        break;
//    case "2":
//        Console.WriteLine("Dopuszczający");
//        break;
//    case "3":
//        Console.WriteLine("Dostatecznie");
//        break;
//    case "4":
//        Console.WriteLine("Dobry");
//        break;
//    case "5":
//        Console.WriteLine("Bardzo dobry");
//        break;
//    case "6":
//        Console.WriteLine("Celujący");
//        break;
//}
//****************************************************************************************************
//Console.WriteLine("exercise 12\n");

//Console.WriteLine("Wpisz jakiś dzień tygodnia od 1-7");
//string weekDay = Console.ReadLine();

//switch (weekDay)
//{
//    case "1":
//        Console.WriteLine("Poniedziałek");
//        break;
//    case "2":
//        Console.WriteLine("Wtorek");
//        break;
//    case "3":
//        Console.WriteLine("Środa");
//        break;
//    case "4":
//        Console.WriteLine("Czwartek");
//        break;
//    case "5":
//        Console.WriteLine("Piątek");
//        break;
//    case "6":
//        Console.WriteLine("Sobota");
//        break;
//    case "7":
//        Console.WriteLine("Niedziela");
//        break;
//}
//****************************************************************************************************
Console.WriteLine("exercise 13\n");
float numb1;
float numb2;
float answer;
Console.WriteLine("Please type in 2 numbers: ");
string number1 = Console.ReadLine();
string number2 = Console.ReadLine();

numb1 = float.Parse(number1);
numb2 = float.Parse(number2);

Console.WriteLine("Please choose a mathematical operation. \n 1.Add \n 2.Subtract \n 3.Multiplication \n 4.Division");
string choice = Console.ReadLine();

switch(choice)
{
    case "1":
        answer = numb1 + numb2;
        Console.WriteLine("The answer for addition is: " + answer);
        break;
    case "2":
        answer = numb1 - numb2;
        Console.WriteLine("The answer for subtraction is: " + answer);
        break;
    case "3":
        answer = numb1 * numb2;
        Console.WriteLine("The answer for multiplication is: " + answer);
        break;
    case "4":
        answer = numb1 / numb2;
        Console.WriteLine("The answer for division is: " + answer);
        break;
}