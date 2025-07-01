using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikkade.Repo
{
    public class AdminUpdateRepo
    {

        public bool AdminUpdateMethod(model.Admin oldadmin, model.Admin newadmin)
        {
            try
            {
                using( Config.AppDbConfig dbconfig = new Config.AppDbConfig())
                {
                    var admin = dbconfig.Admins.FirstOrDefault(a => a.AdminUserId == oldadmin.AdminUserId);
                    if (admin != null)
                    {
                        if (newadmin.AdminUserId != null) admin.AdminUserId = newadmin.AdminUserId;
                        if(newadmin.Name)

                    }
                }
            }
        }
    }
}
