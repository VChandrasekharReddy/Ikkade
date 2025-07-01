using Ikkade.model;
using Ikkade.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikkade.service
{
    public class BillerRegisterService
    {
        BillerRegisterationRepo billerrepo = new BillerRegisterationRepo();
        public bool billerRegistration(Biller biller)
        {
            return billerrepo.billerRegisterRepo(biller);
        }
    }
}
