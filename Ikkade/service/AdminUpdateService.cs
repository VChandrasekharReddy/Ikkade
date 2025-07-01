using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikkade.service
{
    public class AdminUpdateService
    {
        Repo.AdminUpdateRepo adminUpdate;
        public AdminUpdateService()
        {
            adminUpdate = new Repo.AdminUpdateRepo();
        }

        public bool UpdateAdmin(model.Admin oldadmin, model.Admin newadmin)
        {
            return adminUpdate.AdminUpdateMethod(oldadmin, newadmin);
        }
        
    }
}
