using System;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Start.");
            //Singleton obj1 = Singleton.getInstance();
            //Singleton obj2 = Singleton.getInstance();
            //if (obj1 == obj2)
            //{
            //    Console.WriteLine("obj1与obj2是相同的实例。");
            //}
            //else
            //{
            //    Console.WriteLine("obj1与obj2是不同的实例。");
            //}
            //Console.WriteLine("End.");
            //Console.ReadKey();

            #region Q3问题测试

            Console.WriteLine("Start.");
            for(int i=1;i<1000; i++)
            {
                Console.WriteLine(i);
                
                object obj1= new object();
                object obj2 = new object();
                new Task(() => { obj1 = Singleton.getInstance(); }).Start();
                new Task(() => { obj2 = Singleton.getInstance(); }).Start();

                Thread.Sleep(100);

                if (obj1 != obj2)
                {
                    Console.WriteLine("obj1与obj2是不同的实例。");
                    break;
                }
                else
                {
                    ((Singleton)obj1).Dispose();
                }
            }
            
            Console.WriteLine("End.");
            Console.ReadKey();

            #endregion
        }
    }
}
