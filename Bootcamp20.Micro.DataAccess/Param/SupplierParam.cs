using Bootcamp20.Micro.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp20.Micro.DataAccess.Param
{
    public class SupplierParam
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SupplierParam() { }
        public SupplierParam(Supplier supplier)
        {
            this.Id = supplier.Id;
            this.Name = supplier.Name;
        }
    }
}
