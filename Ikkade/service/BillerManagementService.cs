using Ikkade.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikkade.service
{
    internal class BillerManagementService
    {
        BillerAtunticateRepo billerAtunticate;
        public BillerManagementService() {
            billerAtunticate = new BillerAtunticateRepo();
        }


        public bool AuthunticateBiller(model.Biller biller)
        {
            return billerAtunticate.AthunticateBiller(biller);
        }

    }
}
