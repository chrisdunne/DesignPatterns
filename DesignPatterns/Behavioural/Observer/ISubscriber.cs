namespace DesignPatterns.Behavioural.Observer
{
    public interface ISubscriber
    {
        void Update();

        int Notifications { get; }
    }
}