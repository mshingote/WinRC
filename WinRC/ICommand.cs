namespace WinRC
{
    public interface ICommand
    {
        string Args { get; set; }

        void Run();
    }
}