namespace Media
{
    class TvShow
    {
        public string Title { get; set; }
        public int Rating { get; set; }

        public TvShow()
        {

        }

        public TvShow(string title, int rating)
        {
            Title = title;
            Rating = rating;
        }
    }
}
