namespace Design_Principles_3_DependenceInversion.Before
{
    public interface IHardDisk
    {
        void Save(string data);
        string Get();
    }
}