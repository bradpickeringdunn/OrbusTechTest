//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService
{
    using System;
    using System.Collections.Generic;
    
    public partial class DimSalesTerritory
    {
        public DimSalesTerritory()
        {
            this.DimEmployees = new HashSet<DimEmployee>();
            this.DimGeographies = new HashSet<DimGeography>();
            this.FactInternetSales = new HashSet<FactInternetSale>();
            this.FactResellerSales = new HashSet<FactResellerSale>();
        }
    
        public int SalesTerritoryKey { get; set; }
        public Nullable<int> SalesTerritoryAlternateKey { get; set; }
        public string SalesTerritoryRegion { get; set; }
        public string SalesTerritoryCountry { get; set; }
        public string SalesTerritoryGroup { get; set; }
    
        public virtual ICollection<DimEmployee> DimEmployees { get; set; }
        public virtual ICollection<DimGeography> DimGeographies { get; set; }
        public virtual ICollection<FactInternetSale> FactInternetSales { get; set; }
        public virtual ICollection<FactResellerSale> FactResellerSales { get; set; }
    }
}
