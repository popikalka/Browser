using System;

namespace PersonalBrowser.Core.BusinessObjects
{
    public class LinkDto
    {
        public int Id { get; set; }
        public Uri Address { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
    }
}
