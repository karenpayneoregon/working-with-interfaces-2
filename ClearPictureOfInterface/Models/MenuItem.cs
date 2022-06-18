namespace ClearPictureOfInterface.Models
{
    public abstract class MenuItem
    {
        public string Name { get; set; }
        public abstract void BringToTable();
    }
}
