namespace GitHubTest
{
    public class Alper
    {
        public Alper(string isim)
        {
            banaKendiniTanit(isim);
        }
        public string banaKendiniTanit(string isim)
        {
            return $"Merhaba {isim}, ben Alper, nasıl gidiyor?";
        }
    }
}
