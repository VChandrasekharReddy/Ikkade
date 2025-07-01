using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikkade.Repo
{
    public class AdminAtunticateRepo
    {
       public bool ValidateAdmin(model.Admin admin)
        {
            try { 
                using (Config.AppDbConfig dbConfig = new Config.AppDbConfig())
                {
                    var isadmin = dbConfig.Admins.FirstOrDefault(a => a.AdminUserId == admin.AdminUserId);
                    if(isadmin!= null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            } catch {
                return false;
            }
            return false;
        }
    }
}
