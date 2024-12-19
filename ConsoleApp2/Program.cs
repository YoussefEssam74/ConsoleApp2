namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if number can be divided by 3 and 4
            //Console.WriteLine("Enter The Number");
            //int num =int.Parse(Console.ReadLine());
            //if (num % 3 == 0 && num % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            #endregion
            #region negative OR positive
            //Console.WriteLine("Enter The Number");
            //int num =int.Parse(Console.ReadLine());
            //if (num < 0)
            //    Console.WriteLine("Negative");
            //else
            //    Console.WriteLine("positive");

            #endregion
            #region max and min
            //Console.WriteLine("Enter 3 Numbers");
            //int num1=int.Parse(Console.ReadLine());
            //int num2=int.Parse(Console.ReadLine());
            //int num3=int.Parse(Console.ReadLine());
            //int mx = num1, mx2 = Math.Max(num2, num3);
            //int min= num1,min2=Math.Min(num2, num3);
            //if (mx<=mx2)
            //{
            //    mx = mx2;
            //}
            //    Console.WriteLine($"Max Number Is {mx}");
            //if (min >= min2)
            //{
            //    min = min2;
            //}
            //Console.WriteLine($"Min Number Is {min}");


            #endregion
            #region even or odd
            //Console.WriteLine("Enter Number");
            //int num =int.Parse(Console.ReadLine());
            //if(num%2==0)
            //    Console.WriteLine( "Number is even");
            //else
            //    Console.WriteLine("Number is odd");


            #endregion
            #region char is vowel or not
            // Console.WriteLine("Enter char");
            //char chr=Char.Parse(Console.ReadLine());
            // if(chr=='a'  || chr =='A' ||
            //     chr =='E' || chr =='e' ||
            //     chr =='I' || chr =='i' ||
            //     chr =='O' || chr =='o' ||
            //     chr =='U' || chr =='u')
            // {
            //     Console.WriteLine( "Vowel");
            // }
            // else
            //     Console.WriteLine("Consonant");
            #endregion
            #region  multiplication table up to 12
            //Console.WriteLine("Enter an integer");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{num} x {i} = {num * i}");
            //}
            #endregion
            #region power of number
            //int basse = int.Parse(Console.ReadLine());
            //int powerr = int.Parse(Console.ReadLine());
            //long sum = 1;
            //for (int i = 1; i <= powerr; i++)
            //{
            //    sum *= basse;
            //}
            //Console.WriteLine(sum);


            #endregion
            #region calculate total, average and percentage
            //Console.WriteLine("Enter marks of five subjects");
            //int[] marks = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    marks[i] = int.Parse(Console.ReadLine());
            //}
            //int total = 0;
            //foreach (int mark in marks)
            //{
            //    total += mark;
            //}
            //int average = total / 5;
            //double percentage = (total / 500.0) * 100;
            //Console.WriteLine($"Total marks = {total}");
            //Console.WriteLine($"Average marks = {average}");
            //Console.WriteLine($"Percentage = {percentage}%");
            #endregion
            #region month number
            //Console.WriteLine("Enter the Month Number");
            //int month = int.Parse(Console.ReadLine());
            //int daysinMonth;

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        daysinMonth = 31;
            //        break;

            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        daysinMonth = 30;
            //        break;
            //    case 2:
            //        daysinMonth = 28;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Month Number");
            //        return;
            //}
            //        Console.WriteLine($"Days in Month: {daysinMonth}");


            #endregion
            #region Workers
            //Console.Write("Enter the time taken to complete the task");
            //string input = Console.ReadLine();
            //if (double.TryParse(input, out double timeTaken))
            //{
            //    if (timeTaken >= 2 && timeTaken <= 3)
            //    {
            //        Console.WriteLine("The worker is highly efficient");
            //    }

            //    else if (timeTaken > 3 && timeTaken <= 4)
            //    {
            //        Console.WriteLine("The worker needs to increase their speed");
            //    }
            //    else if (timeTaken > 4 && timeTaken <= 5)
            //    {
            //        Console.WriteLine("The worker will be given training to enhance their speed");
            //    }
            //    else if (timeTaken > 5)
            //    {
            //        Console.WriteLine("The worker is required to leave the company");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input Time should be 2 hours or more");
            //    }
            //}
            #endregion
            #region A value 1 will be assigned to d
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            #endregion
            #region 6 1
            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            #endregion
            #region 7 7
            int num = 1, z = 5;


            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);

            #endregion
            /*
             * -------------
             */
            #region Fractions And Discard

            //float myFloat = 10.123456789F;
            //Console.WriteLine(myFloat); // 10.123457

            //double myDouble = 10.123456789_123456789;
            //Console.WriteLine(myDouble);  // 10.123456789123457

            //decimal myDecimal = 10.123456789_123456789_123456789m;
            //Console.WriteLine(myDecimal);  // Decimal: 10.123456789123456789123456789

            //long Number = 10_000_000_000; // Underscores are for readability
            ////Console.WriteLine(Number); // 10000000000
            ////Console.WriteLine($"{Number:c}"); // $10,000,000,000.00
            ////								  // c => format specifier is used to format numbers as currency.

            //var cultureInfo = new CultureInfo("ar-SA");  // Arabic Saudi Arabia (Saudi Riyals)
            //Console.WriteLine(Number.ToString("c", cultureInfo));  // Saudi Riyals
            //													   // ر.س.100,000,000,000.00

            #endregion

            #region Casting 
            #region Implicit And Explicit Casting

            #region Example 01
            //int X = 10000; // 4 Bytes 
            //long Y = X; // 8 Bytes - Implicit Casting 
            //Console.WriteLine(Y); // 10000

            //long A = 10000;
            ////int B = A; // Invalid Implicitly 
            //int B = (int) A; // Explicit Casting Using Casting Operator
            //Console.WriteLine(B); // 10000


            //long C = 100000000000;
            //int D = (int) C; // Explicit Casting - Unsafe Casting [Might Loss Data] 
            //Console.WriteLine(D); // 1215752192 due to overflow

            //checked
            //{
            //	long E = 100000000000;
            //	int F = (int)E; // Explicit Casting - Unsafe Casting [Might Loss Data] 
            //	unchecked
            //	{
            //		Console.WriteLine(F); // System.OverflowException
            //	}
            //}


            // Protective code

            //long K = 12345678912;

            //if (K > int.MaxValue || K < int.MinValue)
            //{
            //	Console.WriteLine("Exception Will Be Throw Due To Overflow");
            //}
            //else
            //{
            //	int M = (int)K;
            //	Console.WriteLine(M);
            //}
            //// Exception Will Be Throw Due To Overflow

            //int M = K.GetType() == typeof(int) ? (int)K : 0;
            //Console.WriteLine(M); // 0 
            #endregion

            #region Example 02

            //int X = 10; // 4 bytes
            //decimal Y = X; // 16 Bytes  [Implicit Casting]
            //Console.WriteLine(Y); // 10



            //decimal K = 10.100M;
            //int M = (int)K; // Explicit Casting [May Cause Loss Of Data]
            //Console.WriteLine(M); // 10

            #endregion

            #endregion

            #region Convert 

            //Console.WriteLine("Please Enter Your Data");
            //Console.Write("Name : ");
            //string? Name =  Console.ReadLine();

            //Console.Write("Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Salary : ");
            //decimal Salary = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("Employee Data :");
            //Console.WriteLine("Name is " + Name);
            //Console.WriteLine("Age is " + Age);
            //Console.WriteLine("Salary is " + Salary);

            #endregion

            #region Parse()
            //Console.WriteLine("Please Enter Your Data");

            //Console.Write("Name : ");
            //string? Name = Console.ReadLine();

            //Console.Write("Age : ");
            //int Age = int.Parse(Console.ReadLine() ?? "0");

            //Console.Write("Salary : ");
            //decimal Salary = decimal.Parse(Console.ReadLine() ?? "0");

            //Console.Clear();
            //Console.WriteLine("Employee Data :");
            //Console.WriteLine("Name is " + Name);
            //Console.WriteLine("Age is " + Age);
            //Console.WriteLine("Salary is " + Salary);
            #endregion

            #region TryParse

            //string number01 = "10";
            //int X01 = int.Parse(number01);
            //Console.WriteLine(X01); // 10

            //string number02 = "Aliaa";
            //int X02 = int.Parse(number02);
            //Console.WriteLine(X02); // System.FormatException


            //string number02 = "Aliaa";
            //bool IsParsed = int.TryParse(number02, out int X02); // doesn't throw exceptions
            //Console.WriteLine(IsParsed); // False 
            //Console.WriteLine(X02); // 0

            //string number03 = "10";
            //IsParsed = int.TryParse(number03, out int X03);
            //Console.WriteLine(IsParsed); // True 
            //Console.WriteLine(X03); // 10

            //Console.WriteLine("Please Enter Your Data");

            //Console.Write("Name : ");
            //string? Name = Console.ReadLine();

            //Console.Write("Age : ");
            //int.TryParse(Console.ReadLine() ?? "0", out int Age);

            //Console.Write("Salary : ");
            //decimal.TryParse(Console.ReadLine() ?? "0", out decimal Salary);

            //Console.Clear();
            //Console.WriteLine("Employee Data :");
            //Console.WriteLine("Name is " + Name);
            //Console.WriteLine("Age is " + Age);
            //Console.WriteLine("Salary is " + Salary);

            #endregion
            #endregion

            #region Operators 

            #region Unary Operators [ ++ , -- ]
            //int X = 10;

            ////1. ++
            //// 1.1 PreFix [Increment and Then Print]
            //Console.WriteLine(++X); // 11
            //Console.WriteLine(X); // 11

            //// 1.2 PostFix [Print and Then Increment]
            //Console.WriteLine(X++); // 10 
            //Console.WriteLine(X); // 11


            ////2. --
            //// 2.1 PreFix [Decrement and Then Print]
            //Console.WriteLine(--X); // 9
            //Console.WriteLine(X); // 9

            //// 2.2 PostFix [Print and Then Decrement]
            //Console.WriteLine(X--); // 10 
            //Console.WriteLine(X); // 9
            #endregion

            #region Binary | Arithmetic Operators [+ , - , * , / , %]

            //int sumResult, subResult, mulResult, divResult, modResult;
            //int number01 = 6, number02 = 2;
            //sumResult = number01 + number02; // 8 
            //subResult = number01 - number02; // 4
            //mulResult = number01 * number02; // 12
            //divResult = number01 / number02; // 3
            //modResult = number01 % number02; // 0

            #endregion

            #region Assignment Operators [= , += , -= , *= , /= , %=]

            //int X;
            //X = 4;
            //X += 2; // X = X + 2
            //X -= 2; // X = X - 2
            //X *= 2; // X = X * 2
            //X /= 2; // X = X / 2
            //X %= 2; // X = X % 2

            #endregion

            #region Relational | Comparsion Operators [== , != , < , > , <=, >=]
            //int X = 10, Y = 10;

            //Console.WriteLine(X == Y); // True
            //Console.WriteLine(X != Y); // False 
            //Console.WriteLine(X > Y); // False 
            //Console.WriteLine(X < Y); // False
            //Console.WriteLine(X >= Y); // True 
            //Console.WriteLine(X <= Y); // True

            #endregion

            #region Logical Operators [! , && , ||]
            //// Short Circuit
            //Console.WriteLine(!true); // False
            //Console.WriteLine(false && true); // False
            //Console.WriteLine(false || true); // True 


            //Console.WriteLine(4 < 5 && 7 < 9); // True
            //Console.WriteLine(4 < 5 && 7 > 9); // False
            //Console.WriteLine(4 > 5 && 7 < 9); // False

            #endregion

            #region BitWise Operator [& , | , ^ , ~ , << , >> ]
            //// Long Circuit
            //Console.WriteLine(false & true); // False
            //Console.WriteLine(true | false); // True 
            //Console.WriteLine(false ^ true); // True 

            //int X = 5 , Y = 3; // X = 0101 , Y = 0011
            //Console.WriteLine(X & Y);  // 1 (0101 & 0011 = 0001)
            //Console.WriteLine(X | Y);  // 7 (0101 | 0011 = 0111)
            //Console.WriteLine(X ^ Y);  // 6 (0101 ^ 0011 = 0110)
            //Console.WriteLine(~X);     // -6 (complement of 0101 is 1010)
            //Console.WriteLine(X << 1); // 10 (1010)  
            //Console.WriteLine(X >> 1); // 2  (0010)
            #endregion

            #region Terany Operator [Conditional Operator] [?:]

            //int X = 10, Y = 5;

            //string Message = X > Y ? "X > Y" : "X < Y";

            //Console.WriteLine(Message);
            #endregion

            #region Operators Priority and Associativity

            //int a = 20;
            //int b = 15;
            //int c = 10;
            //int d = 5;
            //int Result;

            //Result = (a + b) * c / d; // ( 20 + 15 ) * 10 / 5 = 70
            //Result = ((a + b) * c) / d; // (( 20 + 15 ) * 10 ) / 5 = 70
            //Result = (a + b) * (c / d); // ( 20 + 15 ) * ( 10 / 5 ) = 70
            //Result = a + (b * c) / d; // 20 + ( 15 * 10 ) / 5 = 50

            #endregion
            #endregion

            #region String Formatting 
            //// Equation : 10 + 5 = 15
            //int X = 10, Y = 5 , result;
            //result = X + Y;
            //string message;
            //// 1. String Interpolation
            //message = $"Equation : {X} + {Y} = {result}";
            //Console.WriteLine(message);

            //// 2. String.Format Method
            //message = string.Format("Equation : {0} + {1} = {2}" , X , Y ,result);
            //Console.WriteLine(message);

            //// 3. Composite Formatting
            //Console.WriteLine("Equation :x {0} + {1} = {2}" , X , Y , result);

            //// 4. String Concatenation
            //message =  "Equation : " + X + " + " + Y + " = " + result;
            //Console.WriteLine(message);


            //// File Path 
            //// D:\Cycle 43 .Net\Group 06\C#\Session 03\Day03 Solution\Demo\Demo.csproj

            //string filePath = "D:\\Cycle 43 .Net\\Group 06\\C#\\Session 03\\Day03 Solution\\Demo\\Demo.csproj";
            //filePath = @"D:\Cycle 43 .Net\Group 06\C#\Session 03\Day03 Solution\Demo\Demo.csproj";
            //Console.WriteLine(filePath);

            //Console.WriteLine("Aliaa\tTarek\nBackend Instructor");
            ////Aliaa   Tarek
            ////Backend Instructor
            #endregion

            #region Control Statements 
            #region 1. Conditional Statements

            #region Example 01 [Year Quarter] - [If,Switch With Numeric type using Constant Pattern]
            //Console.Write("Please Enter A Month Number Existed in 1st Quarter : ");

            //int.TryParse(Console.ReadLine(), out int monthNumber);

            #region if else
            //if (monthNumber == 1)
            //	Console.WriteLine("Hello January");
            //else if (monthNumber == 2)
            //	Console.WriteLine("Hello February");
            //else if (monthNumber == 3)
            //	Console.WriteLine("Hello March");
            //else
            //	Console.WriteLine("The Entered Month Number is not a Valid Month At First Quarter"); 
            #endregion

            #region switch 
            // Jump Table 
            //switch (monthNumber)
            //{
            //	case 1:
            //		Console.WriteLine("Hello Jan");
            //		break;
            //	case 2:
            //		Console.WriteLine("Hello Feb");
            //		break;
            //	case 3:
            //		Console.WriteLine("Hello March");
            //		break;
            //	default:
            //		Console.WriteLine("The Entered Month Number is not a Valid Month At First Quarter");
            //		break;
            //}
            #endregion

            //Console.ReadKey();
            #endregion

            #region Example 02 [Student Age] - [If,Switch With Numeric type using Relational Pattern]
            /// Age is greater than 22 => Student Age Is greater than 22 
            /// Age is Less than 22 => Student Age Is Less than 22 
            /// Age is 22 => Student Age is 22 

            //Console.Write("Please Enter Student Age : ");
            //int.TryParse(Console.ReadLine(), out int age );

            #region if else
            //if (age > 22)
            //	Console.WriteLine("Student Age Is greater than 22 ");
            //else if (age < 22)
            //	Console.WriteLine("Student Age Is less than 22 ");
            //else
            //	Console.WriteLine("Student Age Is 22 "); 
            #endregion

            #region switch
            // No Jump Table Will be Created 
            //switch( age )
            //{
            //	case > 22:
            //		Console.WriteLine("Student Age Is greater than 22 ");
            //		break;
            //	case < 22:
            //		Console.WriteLine("Student Age Is less than 22 ");
            //		break;
            //	default:
            //		Console.WriteLine("Student Age Is 22");
            //		break;
            //}
            #endregion


            #endregion

            #region Example 03 [Student Name] - [If,Switch With String type]
            /// name = Omar => Hello Omar 
            /// name = May => Hello May 
            /// name = Aliaa => Hello Aliaa 

            //Console.Write("Enter Student Name : ");
            //string name = Console.ReadLine() ?? "No Name Entered";

            #region if else 
            //if(name == "Omar")
            //	Console.WriteLine("Hello Omar");
            //else if(name == "May")
            //	Console.WriteLine("Hello May");
            //else if(name == "Aliaa")
            //	Console.WriteLine("Hello Aliaa");
            #endregion
            #region switch 
            //// No Jump Table Will Be Created
            //// Compiler will generate a sequence of string comparisons
            //switch (name)
            //{
            //	case "Omar":
            //		Console.WriteLine("Hello Omar");
            //		break;
            //	case "May":
            //		Console.WriteLine("Hello May");
            //		break;
            //	case "Aliaa":
            //		Console.WriteLine("Hello Aliaa");
            //		break;
            //}
            #endregion
            #endregion

            #region Example 04 [Budget] - [Switch With Goto]
            /// Budget is 1000 => Option 01
            /// Budget is 2000 => Option 01 , Option 02
            /// Budget is 3000 => Option 01 , Option 02 , Option 03

            //Console.Write("Please Enter Your Budget : ");
            //int.TryParse(Console.ReadLine(), out int Budget);

            //switch(Budget)
            //{
            //	case 1000:
            //		Console.WriteLine("Option 01");
            //		break;
            //	case 2000:
            //		Console.WriteLine("Option 02");
            //		goto case 1000;
            //		//Console.WriteLine("Option 01");
            //		//break;
            //	case 3000:
            //		Console.WriteLine("Option 03");
            //		goto case 2000;
            //		//Console.WriteLine("Option 02");
            //		//Console.WriteLine("Option 01");
            //		//break;
            //}

            #endregion

            #region Goto 

            //Retry:
            //Console.Write("Please Enter Your Name : ");
            //string name = Console.ReadLine();

            //if(name == "Aliaa")
            //	goto Retry;
            //else
            //	Console.WriteLine($"Name is {name}");

            #endregion



            #endregion
            #endregion

        }

    }
}
