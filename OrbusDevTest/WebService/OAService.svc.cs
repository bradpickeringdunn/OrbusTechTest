using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class OAService : IOAService
    {
        public IEnumerable<DimProduct> GetProducts()
        {
            var ent = new AdventureWorksDW2008R2Entities();
            return ent.DimProducts.ToList();
        }

        public DimProduct GetProduct(int productKey)
        {
            var ent = new AdventureWorksDW2008R2Entities();
            return ent.DimProducts.Where(x => x.ProductKey == productKey).FirstOrDefault();
        }
    }
}
