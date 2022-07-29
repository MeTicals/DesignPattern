// 单件模式
namespace Creational_Singleton
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }

    
    // --------------------------------单线程单例模式-----------------------------------
    internal class Singleton
    {
        private static Singleton instance;

        // 私有构造器，避免外部实例化该类
        private Singleton() {}

        // +没有在最上方直接 new ，因为客户如果从头到尾都没有用过这个 Singleton ，就不需要实例化这个对象
        // +当调用 Singleton.Instance 时，会实例化 instance 并永远返回这个 instance
        // -该 Singleton 没有设计它的销毁，但因为一个单例一般不影响实例，一般没必要考虑它的销毁（如果singleton过于复杂应该考虑拆解）
        // -多线程可能得到多个 Singleton 的实例，有可能两个线程同时进行到 if(instance==null) ，都进入了下面的实例化阶段。
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }

                return instance;
            }
        }
    }

    // -------------------------------多线程单例模式-----------------------------------
    internal class SingletonGood
    {
        // 避免编译时编译器优化代码
        private static volatile SingletonGood instance = null;
        // 多线程优化的解决办法
        private static object lockHelper = new object();

        private SingletonGood() { }

        public static SingletonGood Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockHelper)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonGood();
                        }
                    }
                }
                return instance;
            }
        }
    }
    
    // --------------------------------简单的单例模式------------------------------------------
    // +非常简单，两行代码搞定
    // -失去一个参数的来源，如果需要给单例先传一个参数的话是不能实现的
    // 当然实际实际上可以设计一个方法，通过方法给实例内的字段传参数
    internal class SingletonSimple
    {
        // readonly在runtime才会初始化，意味着也是只有在使用到它的时候才会实例化，满足缓释型需要
        // 并且 static 类型初始化机制保证了它只有一个线程可以使用
        public static readonly SingletonSimple Instance = new SingletonSimple();
        private SingletonSimple(){}
    }
    
    // -------------------------------Singleton模式扩展----------------------------------------
    // ·将一个实例扩展到 n 个实例，例如对象池
    // ·将 new 构造器转移到其他的类中，某个局部环境中只需要一个实例
    // ·理解和扩展 Singleton 模式的核心是“如何控制用户使用 new 对一个类的实例构造器的任意调用”
}