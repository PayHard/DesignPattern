using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton singleton = new Singleton();
        private Singleton()
        {
            Console.WriteLine("生成了一个实例。");
        }
        public static Singleton getInstance()
        {
            return singleton;
        }

        #region Q3
        //private static Singleton singleton = null;
        //private Singleton()
        //{
        //    Console.WriteLine("生成了一个实例。");
        //}
        //public static Singleton getInstance()
        //{
        //    if (singleton == null)
        //    {
        //        singleton = new Singleton();
        //    }
        //    return singleton;
        //}

        public void Dispose()
        {
            IDisposable disposable = singleton as IDisposable;
            if (disposable != null)
                disposable.Dispose();
        }

        #endregion

    }
}
