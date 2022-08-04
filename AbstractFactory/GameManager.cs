namespace Creational_AbstractFactory
{
    // GameManager 因为抽象工厂实现了稳定，无论他是古老风格还是现代风格，都可以直接使用
    // 所以也应该注意，它实际上是对象是非常稳定的，只有道路、房屋、地道、丛林这四种对象，但对象的风格变化较多，才适合于抽象工厂模式
    // 也就是对象的数量（结构）不变，但对象本身在扩展，它适用于“多系列对象构建”
    public class GameManager
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
}