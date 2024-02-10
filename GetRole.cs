using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_System
{
    public class GetRole
    {
        public string GetRoleString(int role)
        {
            switch (role)
            {
                case 1:
                    return "Administrator";
                case 2:
                    return "User";
                
                default:
                    return "Unknown Role";
            }
        }

    }
}
