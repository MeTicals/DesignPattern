namespace Design_Principles_1_OpenClose
{
    public static class SkinSetting
    {
        private static AbstractSkin mSkin;

        public static void SetSkin(AbstractSkin skin)
        {
            mSkin = skin;
        }

        public static void Display()
        {
            mSkin.Display();
        }
    }
}