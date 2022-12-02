using System;

namespace EventsLesson
{
    delegate void MoveEventHandler(object source, MoveEventArgs e);
    public class MoveEventArgs : EventArgs
    {
        public int newPosition;
        public bool cancel;

        public MoveEventArgs(int NewPosition)
        {
            this.newPosition = NewPosition;
        }
    }
    
}
