using Bootcamp20.Micro.DataAccess.Models;
using Bootcamp20.Micro.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp20.Micro.Common.Interfaces
{
    public interface ISupplierService
    {
        List<Supplier> Get(); //get all
        Supplier Get(int? id); //get by id
        bool Insert(SupplierParam supplierParam);
        bool Update(SupplierParam supplierParam);
        bool Delete(int? id);
    }
}
