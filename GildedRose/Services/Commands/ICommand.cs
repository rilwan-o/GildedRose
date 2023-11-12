namespace GildedRose.Services.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
