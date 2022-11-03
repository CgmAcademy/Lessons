namespace StreamingPlayer
{
    public sealed class Spotify : StreamingPlatform
    {   
        public Spotify()
        {
            files = new SpotifyMusic[] {
                new SpotifyMusic(){ title ="Back in Blak"},
                new SpotifyMusic(){ title ="Hightway to Hell"},
                new SpotifyMusic(){ title ="Nothing else Meatters", },
                new SpotifyMusic(){ title ="Fear of the Dark"}

                };
        }
        private class SpotifyMusic: Music 
        {  
            public SpotifyMusic()
            {
            }
        }
    } 
   
}
