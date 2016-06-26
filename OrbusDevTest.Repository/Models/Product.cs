using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrbusDevTest.DataAccess.Models
{
    public class Product
    {
        // WebService Name ProductKey
        public int ProductKey { get; set; }

        // WebService Name EnglishProductName
        public string Name { get; set; }

        // WebService Name SafetyStockLevel
        public short? StockLevel { get; set; }
    }
}