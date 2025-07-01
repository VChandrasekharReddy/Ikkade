using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ikkade.service
{
    public class AdminLoginService
    {
        Repo.AdminAtunticateRepo adminAtuntication;


        public AdminLoginService() {
             adminAtuntication = new Repo.AdminAtunticateRepo();
        }






        public bool IsAdmin { get; set; }
        public bool AdminAtunticate(Ikkade.model.Admin admin)
        {

            return adminAtuntication.ValidateAdmin(admin);
        }


    }
}
