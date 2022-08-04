namespace Creational_Builder
{
    public class GameManager
    {
        // 我们认为房子的主线是不动的，也就是房子的结构稳定，但是可能门窗的风格用户会经常去修改
        public static House CreateHouse(Builder builder)
        {
            builder.BuildDoor();
            builder.BuildDoor();
            
            builder.BuildWindows();
            builder.BuildWindows();
            
            builder.BuildWall();
            builder.BuildWall();
            builder.BuildWall();
            builder.BuildWall();
            
            builder.BuildFloor();
            
            builder.BuildHouseCeiling();
            
            return builder.GetHouse();
        }
    }
}