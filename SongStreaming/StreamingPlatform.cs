using System;

namespace StreamingPlayer
{
    public abstract class StreamingPlatform : IPlayer
    {
        protected MediaFile playing;
        protected MediaFile[] files;
       
        public virtual void Play(int MediaIndex)
        {

            if (MediaIndex >= 0 && MediaIndex <= files.Length - 1)
            {
                playing = files[MediaIndex];
                playing.position = MediaIndex + 1;
            }
            else
            {
                playing = files[0];  // Non fa andare piu indietro della prima traccia !
                playing.position = 1;
            }
            ShowPlaying();
        }
        public virtual void StartPlaying()
        {

            if (playing is null)// Controlla se c'è già una brano che stata suonando 
            {
                // SongIndex  = new Random().Next(0, songs.Length - 1); // prendi un brano a caso
                playing = files[0]; // Prelevo il brano dall'array  con l'indice creato
                playing.position = 0;
            }
            ShowPlaying();
        }
        public virtual void ShowPlaying()
        {
            Console.BackgroundColor = ConsoleColor.Yellow; // Cambio il colore di sfondo della riga a video
            Console.ForegroundColor = ConsoleColor.Blue; // Cambio il colore del  test  della riga a video
            Console.WriteLine($"Playing now : - Postion: {playing.position} - {playing.title.ToUpper()}");
            Console.ResetColor();

        }
        public virtual void Stop()
        {
            playing.state = MediaFile.MediaState.Stopped;
        }
        public virtual void Pause()
        {
            playing.state = MediaFile.MediaState.Paused;
        }
        public virtual void Rate()
        {
            playing.rated = true;
        }
        public virtual void Forward()
        {
            int next = Array.FindIndex(files, i => i.title == playing.title);
            Play(next + 1);
        }
        public virtual void Backward()
        {
            int next = Array.FindIndex(files, i => i.title == playing.title);
            Play(next - 1);
        }
        public virtual void ListSongs()
        {
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine($"{i + 1} -   {files[i].title} ");
            }

        }


        protected class MediaFile
        {
            public int id;
            public string title;
            public MediaState state = MediaState.Paused;
            public bool rated;
            public int position;
            public MediaFile()
            {              
            }

            public enum MediaState
            {
                Playing,
                Paused,
                Stopped
            }

        }
        protected class Music : MediaFile
        {          
            public Music()
            {

            }
        }
        protected class Video : MediaFile
        {
            public Video()
            {

            }
        }

    }
}
