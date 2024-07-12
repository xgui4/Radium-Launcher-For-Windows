using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radium_Launcher_For_Windows.Server.Database.Enum
{
    public enum AccountType
    {
        SuperUser = 1, //Maximum authorisation
        Admin = 2,
        Moderator = 3,
        User = 4,
        Guest = 5, //Not registred
    }
}
