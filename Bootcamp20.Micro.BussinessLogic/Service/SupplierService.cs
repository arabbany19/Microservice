using Bootcamp20.Micro.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bootcamp20.Micro.DataAccess.Models;
using Bootcamp20.Micro.DataAccess.Param;
using Bootcamp20.Micro.Common.Interfaces.Application;

namespace Bootcamp20.Micro.BussinessLogic.Service
{
    public class SupplierService : ISupplierService //inherit atau extend ke ISuppServ
    {
        //controller manggil ISupplierService
        //pake Unity.MVC5
        //SupplierService manggil ISupplierRepository utk manggil function2 yg ada di ISuppRepo
        //SupplierRepository manggil Context

        private readonly ISupplierRepository _supplierRepository; //utk manggil function2 yg ada di ISuppRepo

        public SupplierService() { }

        //konstruktor untuk menghubung class dengan inteface
        public SupplierService(ISupplierRepository supplierRepository) //manggil yg diatas repo 
        {
            this._supplierRepository = supplierRepository;
        }

        public bool Delete(int? id) //tinggal manggil function yg ada di ISuppRepo
        {
            return _supplierRepository.Delete(id);
        }

        public List<Supplier> Get()
        {
            return _supplierRepository.Get();
        }

        public Supplier Get(int? id)
        {
            return _supplierRepository.Get(id);
        }

        public bool Insert(SupplierParam supplierParam)
        {
            return _supplierRepository.Insert(supplierParam);
        }

        public bool Update(SupplierParam supplierParam)
        {
            return _supplierRepository.Update(supplierParam);
        }
    }
}
