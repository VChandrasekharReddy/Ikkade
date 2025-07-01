using Ikkade.Config;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikkade.Repo
{
    public class BillerAtunticateRepo
    {
        public bool AthunticateBiller(model.Biller biller)
        {
            try { 
            using( Config.AppDbConfig config = new AppDbConfig())
                {
                   var isvalid = config.Biller.FirstOrDefault(b => b.BillerUserId == biller.BillerUserId);
                    if (isvalid != null)
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
        }
    }
}
