namespace Creational_Builder
{
    public class RomanHouse : House
    {
    
    }

    public class RomanDoor : Door
    {
        
    }
    public class RomanWall : Wall
    {
        
    }
    public class RomanWindows : Windows
    {
        
    }
    public class RomanFloor : Floor
    {
        
    }
    public class RomanHouseCeiling : HouseCeiling
    {
        
    }
   
    public class RomanHouseBuilder : Builder
    {
        private RomanHouse _romanHouse = new RomanHouse();
        public override void BuildDoor()
        {
            _romanHouse.houseString += "RomanDoor\n";
        }

        public override void BuildWall()
        {
            _romanHouse.houseString += "RomanWall\n";
        }

        public override void BuildWindows()
        {
            _romanHouse.houseString += "RomanWindows\n";
        }

        public override void BuildFloor()
        {
            _romanHouse.houseString += "RomanFloor\n";
        }

        public override void BuildHouseCeiling()
        {
            _romanHouse.houseString += "RomanHouseCeiling\n";
        }

        public override House GetHouse()
        {
            return _romanHouse;
        }
    }
}