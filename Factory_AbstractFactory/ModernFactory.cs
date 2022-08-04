using System;

namespace Creational_AbstractFactory
{
    public class ModernRoad : Road
    {
        public override void Log() => Console.WriteLine("现代化道路");
    }

    public class ModernBuilding : Building
    {
        public override void Log() => Console.WriteLine("现代化建筑");
    }

    public class ModernTunnel : Tunnel
    {
        public override void Log() => Console.WriteLine("现代化地道");
    }

    public class ModernJungle : Jungle
    {
        public override void Log() => Console.WriteLine("现代化丛林");
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
}