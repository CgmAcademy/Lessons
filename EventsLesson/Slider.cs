namespace EventsLesson
{
    class Slider
    {
        public string Name { get; set; }
        int position;
        public event MoveEventHandler SliderChanged;
        public int Position
        {
            get { return position; }
            set
            {
                if (position != value)
                {
                    if (SliderChanged != null)
                    {
                        MoveEventArgs moveEventArgs = new MoveEventArgs(value);
                        SliderChanged(this, moveEventArgs);
                        if (moveEventArgs.cancel)
                        {
                            return;
                        }
                    }
                    position = value;
                }
            }
        }

    }


}
