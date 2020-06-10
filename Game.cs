namespace Video_Game_Index
{
    class Game
    {
        public string name;
        public string developer;
        public string genre;
        public string platform;
        public int release;

        public Game(string aName, string aDeveloper, string aGenre, string aPlatform, int aRelease)
        {
            name = aName;
            developer = aDeveloper;
            genre = aGenre;
            platform = aPlatform;
            release = aRelease;
        }
    }
}
