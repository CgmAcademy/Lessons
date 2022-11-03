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
        }
        private class NetflixVideo : Video
        {
            public NetflixVideo()
            {
            }
        }
    }
   
}
