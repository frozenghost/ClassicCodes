using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicCodes
{
    /// <summary>
    /// 懒汉式单例
    /// 延迟加载对象
    /// </summary>
    public class Singleton2
    {
        private static Singleton2 instance = null;
        private static readonly object syncLocker = new object();

        private static Singleton2 badInstance = null;

        public static Singleton2 GetInstance()
        {
            // 第一重判断
            if (instance == null)
            {
                // 锁定代码块
                lock (syncLocker)
                {
                    // 第二重判断
                    if (instance == null)
                    {
                        instance = new Singleton2();
                    }
                }
            }
            return instance;
        }

        public static Singleton2 GetBadInstance()
        {
            if (badInstance == null)
            {
                lock (syncLocker)
                {
                    Task.Delay(5000).Wait();
                    badInstance = new Singleton2();
                }
            }
            return badInstance;
        }
    }
}
