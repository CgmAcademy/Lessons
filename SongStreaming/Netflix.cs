namespace StreamingPlayer
{
    public sealed class Netflix : StreamingPlatform
    {
        public Netflix()
        {
            files = new NetflixVideo[] {
                new NetflixVideo(){ title ="Titanic"},
                new NetflixVideo(){ title ="Terminator"},
                new NetflixVideo(){ title ="Alien", },
                new NetflixVideo(){ title ="Avatar"}

                };

            totalTacks = files.Length;
        }
        private class NetflixVideo : Video
        {
            public NetflixVideo()
            {
            }
        }
    }
   
}
