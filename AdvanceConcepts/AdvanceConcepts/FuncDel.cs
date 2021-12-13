using System;


namespace AdvanceConcepts
{
    //  This program demo. how to declare Func Delegate.
    //  This is generic in-built delegate.
    //  It is like Action delegate but it returns a value
    //  Out param must be a last param in list.
    class FuncDel
    {
        //public delegate TResult Func<in T1,in T2, out TResult>(int firstNum, int secondNum, out int result);
       
        public static int Add(int firstNum,int secondNum)
        {
            return firstNum + secondNum;
        }
        public static int AddAndSub(int firstNum, int secondNum,out int result)
        {
            result = firstNum - secondNum;
            return firstNum + secondNum;
        }
        static void Main()
        {

            Func<int, int, int> func = Add;
            Console.WriteLine(func(30,40));
            //int Result;
           // Func<int, int, int> func1 = AddAndSub;
           //Console.WriteLine($"The Add result is: {func1(20, 10, out Result)}");
           // Console.WriteLine($"The sub result is:{Result}");
            Console.ReadLine();
        }
    }
}
