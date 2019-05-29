namespace DesignPatterns.Behavioural.NullObject
{
    public class MainMovement : IMovement
    {
        private int _x;
        private int _y;

        public void Backwards()
        {
            _x--;
        }

        public void Down()
        {
            _y--;
        }

        public void Forwards()
        {
            _x++;
        }

        public void Up()
        {
            _y++;
        }
    }
}