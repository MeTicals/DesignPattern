namespace Creational_AbstractFactory
{
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

}