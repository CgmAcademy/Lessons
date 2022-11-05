namespace StreamingPlayer
{
    public sealed class Spotify : StreamingPlatform
    {   

        public Spotify()
        {
            files = new SpotifyMusic[] {
                new SpotifyMusic(){ title ="Back in Blak", Color = System.ConsoleColor.Blue},
                new SpotifyMusic(){ title ="Hightway to Hell",Color = System.ConsoleColor.Cyan },
                new SpotifyMusic(){ title ="Nothing else Meatters",Color = System.ConsoleColor.Green },
                new SpotifyMusic(){ title ="Fear of the Dark",Color = System.ConsoleColor.Yellow}

                };
            totalTacks = files.Length;
        }
        private class SpotifyMusic: Music 
        {  
            public SpotifyMusic()
            {
            }
        }
    } 
   
}
