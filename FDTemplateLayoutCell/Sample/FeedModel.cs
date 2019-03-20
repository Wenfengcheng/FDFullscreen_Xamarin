using System;
namespace Sample
{
    public class Feed
    {
        public string UserName { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string ImageName { get; set; }

        public string Time { get; set; }

    }

    public class FeedModel
    {
        public Feed[] Feed { get; set; }
    }
}
