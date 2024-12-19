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

        }

    }
}
