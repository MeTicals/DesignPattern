namespace Creational_Builder
{
    public abstract class House
    {
        public string houseString;
    }
    public abstract class Door
    {
    }
    public abstract class Wall
    {
    }
    public abstract class Windows
    {
    }
    public abstract class Floor
    {
    }
    public abstract class HouseCeiling
    {
    }
    
    public abstract class Builder
    {
        public abstract void BuildDoor();
        public abstract void BuildWall();
        public abstract void BuildWindows();
        public abstract void BuildFloor();
        public abstract void BuildHouseCeiling();

        public abstract House GetHouse();
    }
}