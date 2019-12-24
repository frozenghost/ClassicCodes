using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicCodes
{
    /// <summary>
    /// 单例模式最终版
    /// 既实现了延迟加载，又减少了性能问题，巧妙利用了C#语言的内部机制
    /// </summary>
    public class Singleton3
    {
        // 公共静态成员方法，返回唯一实例
        public static Singleton3 GetInstance()
        {
            return Nested.instance;
        }

        // 使用内部类+静态构造函数实现延迟初始化
        class Nested
        {
            static Nested() { }
            internal static readonly Singleton3 instance = new Singleton3();
        }
    }
}
