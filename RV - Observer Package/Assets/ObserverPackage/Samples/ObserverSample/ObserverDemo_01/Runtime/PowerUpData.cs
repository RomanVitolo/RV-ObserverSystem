namespace ObserverPackage.Samples.Runtime.ObserverDemo_01
{
    public enum PowerUpType
    {
        Health,
        Speed,
        Shield
    }

    public class PowerUpData
    {
        public PowerUpType Type { get; }
        public int Count { get; }

        public PowerUpData(PowerUpType type, int count)
        {
            Type = type;
            Count = count;
        }
    }
}