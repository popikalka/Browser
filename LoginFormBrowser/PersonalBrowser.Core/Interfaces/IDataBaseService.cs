using PersonalBrowser.Core.BusinessObjects;
using System.Collections.Generic;

namespace PersonalBrowser.Core.Interfaces
{
    public interface IDataBaseService
    {
        bool AddLink(LinkDto link);
        bool EditLink(LinkDto link);
        bool DeleteLink(LinkDto link);
        UserDto GetUser(string userName);
    }
}
