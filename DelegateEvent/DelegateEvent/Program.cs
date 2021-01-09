using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    class Program
    {
        #region Delegate
        //public delegate bool Check(int n);
        //public delegate void Print(string str);
        //public delegate void PrintInt(int str);
        //public delegate void Print<T>(T p);
        //public delegate R Test<in T, out R>(T p);
        //public delegate string Calculate(int n1, string n2);
        #endregion
        static void Main(string[] args)
        {
            #region Delegate
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(Sum(arr,IsEven));
            //Console.WriteLine(Sum(arr,IsOdd));
            //Console.WriteLine(Sum(arr,IsElder));
            #region Anonimous functions,lambda expression
            //Test<int, string> test = delegate (int n)
            //   {
            //       return n.ToString();
            //   };
            //Print<int> p1 = delegate (int n)
            //  {
            //      Console.WriteLine(n);
            //  };
            //Print<string> p2 = delegate (string s)
            //  {
            //      Console.WriteLine(s);
            //  };
            //Calculate c1 = (n1, n2) =>
            //    {
            //        return n1 + n2;
            //    };
            //Console.WriteLine(c1(10, ""));
            //Print print = new Print(WriteStr);
            //Print print = WriteStr;
            //print += WriteStrLength;
            //print += GetUpper;
            //print += delegate (string s)
            // {
            //     Console.WriteLine($"String[0]: {s[0]}");
            // };
            //print += s => Console.WriteLine($"String[Last]: {s[s.Length - 1]}");

            //print -= GetUpper;
            //print -= WriteStrLength;
            //print -= delegate (string s)
            //{
            //    Console.WriteLine($"String[0]: {s[0]}");
            //};
            //print("Pervin");
            //print.Invoke("Pervin");
            #endregion

            #region Action,Func,Predicate
            #region Action
            //Action<int> action = n => Console.WriteLine(n);
            //action(5);
            //Action<int, int> action1 = delegate (int n1, int n2)
            //{
            //    Console.WriteLine($"{n1 + n2}");
            //};
            //action1(5, 6);
            //Action<string> print = WriteStr;
            //print += WriteStrLength;
            //print += GetUpper;
            //print += s => Console.WriteLine($"String[0]: {s[0]}");

            //print -= GetUpper;
            //print("Pervin");
            #endregion

            #region Func
            //Func<int, string> func = n =>
            // {
            //     Console.WriteLine("first");
            //     return n.ToString();
            // };
            //func += PervinTest;
            //Console.WriteLine(func(10));
            #endregion

            #region Predicate
            //Predicate<int> predicate = IsEven;
            //predicate += n =>
            //{
            //    return n > 30;
            //};
            //Console.WriteLine(predicate(10));

            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(10);
            //list.Add(100);
            ////Console.WriteLine(list.Find(n => n %2==0));

            //foreach (var item in list.FindAll(n => n % 2 != 0))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #endregion

            #region Event
            Student s1 = new Student("Anar", 65);
            Student s2 = new Student("Pervin", 94);
            
            s1.Notify += score =>
            {
                if (score >= 65)
                {
                    Console.WriteLine("Anardan yoxdu,the best,eshq olsun!!!");
                    return;
                }
                Console.WriteLine("Biz tehsil size layiq deyildi");
            };

            s2.Notify+=score=>
            {
                if (score >= 65)
                {
                    Console.WriteLine("Tebrikler!!!");
                    return;
                }
                Console.WriteLine("Teessuf");
            };

            s1.SendMessage();
            s2.SendMessage();
            #endregion
        }

        #region Delegate
        #region Anonimous functions,lambda expression

        static string PervinTest(int n)
        {
            Console.WriteLine("second");
            return $"Pervin:{n.ToString()}";
        }
        public static void WriteStr(string str)
        {
            Console.WriteLine($"String: {str}");
        }

        public static void WriteStrLength(string s)
        {
            Console.WriteLine($"String length: {s.Length}");
        }

        public static void GetUpper(string s)
        {
            Console.WriteLine($"String ToUpper: {s.ToUpper()}");
        }
        #endregion
        //static int Sum(int[] arr,Check func)
        //{
        //    int result = 0;
        //    foreach (int item in arr)
        //    {
        //        if (func(item))
        //            result += item;
        //    }
        //    return result;
        //}


        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }

        static bool IsElder(int num)
        {
            return num > 5;
        }
        #endregion
    }

    #region Event
    class Student
    {
        public string Name { get; set; }
        private int Score;
        public event Action<int> Notify;

        public Student(string name,int score)
        {
            Name = name;
            Score = score;
        }

        public void SendMessage()
        {
            Notify(Score);
        }
    }
    #endregion
}
