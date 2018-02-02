using System.Collections.Generic;

namespace PersonalBrowser.Core.BusinessObjects
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<LinkDto> Links { get; set; }
    }
}
