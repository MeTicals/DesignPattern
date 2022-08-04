using System;
namespace Creational_AbstractFactory
{
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
            Console.WriteLine("古老版建筑");
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
            return new OldRoad();
        }

        public override Building CreateBuilding()
        {
            return new OldBuilding();
        }

        public override Tunnel CreateTunnel()
        {
            return new OldTunnel();
        }

        public override Jungle CreateJungle()
        {
            return new OldJungle();
        }
    }
}