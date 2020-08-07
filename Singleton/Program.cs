using System;

namespace Singleton
{
    class Program
    {
        /**
         * 设计原则：无
         * 常用场景：应用中有对象需要是全局的且唯一
         * 使用概率：99.99999%
         * 复杂度：低
         * 变化点：无
         * 选择关键点：一个对象在应用中出现多个实例是否会引起逻辑上或者是程序上的错误
         * 逆鳞：在以为是单例的情况下，却产生了多个实例
         * 相关设计模式
         *   原型模式：单例模式是只有一个实例，原型模式每拷贝一次都会创造一个新的实例        
         */
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Logger.GetLogger().Log("test2222");

            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
