namespace GitHubTest
{
    class Samet
    {
        private int _say;

        public Samet(int say)
        {
            Say = say;
        }

        public int Say { get => _say; set => _say = value; }
    }
}
