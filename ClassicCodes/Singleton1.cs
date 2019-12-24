using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClassicCodes
{
    /// <summary>
    /// 饿汉式单例
    /// C#的语法中有一个函数能够确保只调用一次，那就是静态构造函数，当.NET运行时发现第一次使用该类型的时候自动调用该类型的静态构造函数，不过这样会过早地创建实例，但是对于多线程并无问题
    /// </summary>
    public class Singleton1
    {
        private static readonly Singleton1 instance = new Singleton1();


        private IList<string> dataSource = null;

        private Singleton1()
        {
            dataSource = new List<string>();
            Console.WriteLine("initialize...");
            //初始化动作...
            Task.Delay(3000).Wait();
        }

        public static Singleton1 GetInstance()
        {
            return instance;
        }

        public void AddItem(string item)
        {
            this.dataSource.Add(item);
        }
    }
}
