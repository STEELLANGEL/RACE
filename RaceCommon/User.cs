namespace RaceCommon
{
    public class User
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Coin { get; set; }

        public User(string name)
        {
            Name = name;
            Score = 0;
            Coin = 0;
        }
    }
}
