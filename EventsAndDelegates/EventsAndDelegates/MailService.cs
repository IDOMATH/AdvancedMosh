﻿using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mail service sending email" + e.Video.Title);
        }
    }
}
