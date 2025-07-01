using Ikkade.Config;
using Ikkade.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikkade.Repo
{
    internal class BillerRegisterationRepo
    {
        public bool billerRegisterRepo(Biller biller)
        {
            try 
            {
                using (AppDbConfig dbConfig = new AppDbConfig())
                {
                    dbConfig.Biller.Add(biller);
                    dbConfig.SaveChanges();
                    return true;
                }
            }
            catch 
            {
                return false;
            }
        }


    }
}
