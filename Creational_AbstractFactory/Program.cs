// 2.抽象工厂模式
// new的问题：实现依赖，不能应对“具体实例化类型”的变化
// 解决思路：封装变化点，哪里变化才需要封装哪里
// 适用于对象的数量（结构）不变，但对象本身在扩展，它适用于“多系列对象构建”，一定要寻找变化点

//-----------------------------------简单工厂--------------------------------

using System;

namespace Creational_AbstractFactory1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 举例，有大量地方都使用了Road road = new road(); 而路可能经常要换，过两天换成水泥路，换成高速路等
            // 如果此时需要把new road(); 改成 new WaterRoad(); 就需要修改很多地方
            Road road = RoadFactory.CreateRoad();
            Road road2 = RoadFactory.CreateRoad();
            Road road3 = RoadFactory.CreateRoad();
            Road road4 = RoadFactory.CreateRoad();
            Road road5 = RoadFactory.CreateRoad();
        }
    }

    // 路类
    abstract class Road
    {
        
    }

    // 路的细分之一，水路
    class WaterRoad : Road
    {
        
    }
    
    // 所有的Road都是从RoadFactory拿到的，如果以后需要把路改成其他的，只需要修改这里的return
    class RoadFactory
    {
        public static Road CreateRoad()
        {
            return new WaterRoad();
        }
    }
}


//----------------------抽象工厂----------------------
namespace Creational_AbstractFactory2
{
    class Program
    {
        public static void Main2()
        {
            GameManager g = new GameManager(new ModernFacilityFactory());
            g.BuildGameFacilities();
            g.Play();

            GameManager g2 = new GameManager(new OldFacilityFactory());
            g.BuildGameFacilities();
            g.Play();
        }
    }

    // GameManager 因为抽象工厂实现了稳定，无论他是古老风格还是现代风格，都可以直接使用
    // 所以也应该注意，它实际上是对象是非常稳定的，只有道路、房屋、地道、丛林这四种对象，但对象的风格变化较多，才适合于抽象工厂模式
    // 也就是对象的数量（结构）不变，但对象本身在扩展，它适用于“多系列对象构建”
    class GameManager
    {
        FacilityFactory _facilityFactory;
        private Road road;
        private Building building;
        private Tunnel tunnel;
        private Jungle jungle;

        public GameManager(FacilityFactory facilityFactory)
        {
            this._facilityFactory = facilityFactory;
        }

        public void BuildGameFacilities()
        {
            road = _facilityFactory.CreateRoad();
            building = _facilityFactory.CreateBuilding();
            tunnel = _facilityFactory.CreateTunnel();
            jungle = _facilityFactory.CreateJungle();
        }

        public void Play()
        {
            road.Log();
            building.Log();
            tunnel.Log();
            jungle.Log();
        }
    }

    #region 抽象工厂
    // 道路
    public abstract class Road
    {
        public abstract void Log();
    }

    // 房屋
    public abstract class Building
    {
        public abstract void Log();
    }

    // 地道
    public abstract class Tunnel
    {
        public abstract void Log();
    }

    // 丛林
    public abstract class Jungle
    {
        public abstract void Log();
    }

    public abstract class FacilityFactory
    {
        public abstract Road CreateRoad();
        public abstract Building CreateBuilding();
        public abstract Tunnel CreateTunnel();
        public abstract Jungle CreateJungle();
    }
    

    #endregion
    
    #region 具体实现方法1（现代版本）
    public class ModernRoad : Road
    {
        public override void Log()
        {
            Console.WriteLine("现代化道路");
        }
    }
    
    public class ModernBuilding : Building
    {
        public override void Log()
        {
            Console.WriteLine("现代化建筑");
        }
    }

    public class ModernTunnel : Tunnel
    {
        public override void Log()
        {
            Console.WriteLine("现代化地道");
        }
    }
    
    public class ModernJungle : Jungle
    {
        public override void Log()
        {
            Console.WriteLine("现代化丛林");
        }
    }

    public class ModernFacilityFactory : FacilityFactory
    {
        public override Road CreateRoad()
        {
            return new ModernRoad();
        }

        public override Building CreateBuilding()
        {
            return new ModernBuilding();
        }

        public override Tunnel CreateTunnel()
        {
            return new ModernTunnel();
        }

        public override Jungle CreateJungle()
        {
            return new ModernJungle();
        }
    }
    #endregion
  
    #region 具体实现方法2（古代版本）
    public class OldRoad : Road
    {
        public override void Log()
        {
            Console.WriteLine("古老版道路");
        }
    }
    
    public class OldBuilding : Building
    {
        public override void Log()
        {
            Console.WriteLine("古老版");
        }
    }

    public class OldTunnel : Tunnel
    {
        public override void Log()
        {
            Console.WriteLine("古老版地道");
        }
    }
    
    public class OldJungle : Jungle
    {
        public override void Log()
        {
            Console.WriteLine("古老版丛林");
        }
    }

    public class OldFacilityFactory : FacilityFactory
    {
        public override Road CreateRoad()
        {
            return new ModernRoad();
        }

        public override Building CreateBuilding()
        {
            return new ModernBuilding();
        }

        public override Tunnel CreateTunnel()
        {
            return new ModernTunnel();
        }

        public override Jungle CreateJungle()
        {
            return new ModernJungle();
        }
    }
    #endregion
}