using System;

namespace Mocking
{
    public class MailBox
    {
        public MailBox()
        {
        }

        public int NumReceivedMessages { get; set; }

        internal string GetLatestMessageText()
        {
            throw new NotImplementedException();
        }

        internal void Add(Mail o)
        {
            throw new NotImplementedException();
        }
    }
}