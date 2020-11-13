using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //Stuff
                throw new Exception("some low-level error");
            }
            catch (Exception ex)
            {
                // Log the error
                throw new YouTubeException("Something went wrong retrieving videos", ex);
            }

            return new List<Video>();
        }
    }
}
