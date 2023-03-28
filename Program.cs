namespace GenericAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Generic Program");
            //Console.WriteLine("Please Enter the FirstValue:");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please Enter the SecondValue:");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please Enter the ThirdValue:");
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //int val = FindMax.MaximumNum(num1, num2, num3);
            //Console.WriteLine("{0} is greater", val);


            //Console.WriteLine("Welcome to Generic Program");
            //Console.WriteLine("Please Enter the FirstValue:");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Please Enter the SecondValue:");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Please Enter the ThirdValue:");
            //double num3 = Convert.ToDouble(Console.ReadLine());
            //double val = FindMaxFloat.MaximumNum(num1, num2, num3);
            //Console.WriteLine("{0} is greater", val);


            //Console.WriteLine("Welcome to Generic Program");
            //Console.WriteLine("Please Enter the FirstValue:");
            //string str1 = Console.ReadLine();
            //Console.WriteLine("Please Enter the SecondValue:");
            //string str2 = Console.ReadLine();
            //Console.WriteLine("Please Enter the ThirdValue:");
            //string str3 = Console.ReadLine();
            //string val = FindMaxString.MaximumVal(str1, str2, str3);
            //Console.WriteLine("{0} is greater", val);


            //Console.WriteLine("Please Enter the FirstValue:");
            //var val1 = Console.ReadLine();
            //Console.WriteLine("Please Enter the SecondValue:");
            //var val2 = Console.ReadLine();
            //Console.WriteLine("Please Enter the ThirdValue:");
            //var val3 = Console.ReadLine();

            //var Value = Refector1.MaximumNum(val1, val2, val3);
            //Console.WriteLine("{0} is greater", Value);


            //int a = 10, b = 20, c = 15;
            //double x = 5.5, y = 7.7, z = 10.0;
            //string p = "ram", q = "shiv", r = "radha";

            //Refector2<int> obj = new Refector2<int>(a, b, c);
            //int MaxInt = obj.TestMaximum();
            //Console.WriteLine("Maximum value in integer is: " + MaxInt);
            //Console.WriteLine("****************************************");

            //Refector2<double> obj1 = new Refector2<double>(x, y, z);
            //double MaxDouble = obj1.TestMaximum();
            //Console.WriteLine("Maximum value in double is: " + MaxDouble);
            //Console.WriteLine("****************************************");

            //Refector2<string> obj2 = new Refector2<string>(p, q, r);
            //string MaxString = obj2.TestMaximum();
            //Console.WriteLine("Maximum value in string is: " + MaxString);
            //Console.WriteLine("****************************************");


            //int[] valuesInt = { 1, 2, 3, 4, 5 };
            //double[] valuesDouble = { 10.4, 6.7, 8.2, 9.5, 7.3 };
            //string[] valuesString = { "ram", "shiv", "radha" };

            //FindMax2<int> obj = new FindMax2<int>(valuesInt);
            //int MaxInt = obj.TestMaximum();
            //Console.WriteLine("Maximum value in integer is: " + MaxInt);
            //Console.WriteLine("**********************************************");


            //FindMax2<double> obj1 = new FindMax2<double>(valuesDouble);
            //double MaxDouble = obj1.TestMaximum();
            //Console.WriteLine("Maximum value in double is: " + MaxDouble);
            //Console.WriteLine("**********************************************");

            //FindMax2<string> obj2 = new FindMax2<string>(valuesString);
            //string MaxString = obj2.TestMaximum();
            //Console.WriteLine("Maximum value in string is: " + MaxString);
            //Console.WriteLine("**********************************************");


            int[] valuesInt = { 1, 2, 3, 4, 5 };
            double[] valuesDouble = { 10.4, 6.7, 8.2, 9.5, 7.3 };
            string[] valuesString = { "ram", "shiv", "radha", "mohan" };

            FindMax3<int> obj = new FindMax3<int>(valuesInt);
            obj.PrintMax();
            Console.WriteLine("**********************************************");


            FindMax3<double> obj1 = new FindMax3<double>(valuesDouble);
            obj1.PrintMax();
            Console.WriteLine("**********************************************");

            FindMax3<string> obj2 = new FindMax3<string>(valuesString);
            string MaxString = obj2.TestMaximum();
            obj2.PrintMax();
        }
    }
}