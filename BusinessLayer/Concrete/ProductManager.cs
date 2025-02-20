using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Constants;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Domain.Concrete.Entity;
using Domain.DTOs;

namespace BusinessLayer.Concrete
{
    public class ProductManager:IProductService
    {
        private EFProductDAL _productDal;

        public ProductManager(EFProductDAL productDal)
        {
            _productDal = productDal;
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id),Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(
                _productDal.GetAll(p => p.UnitPrice == min || p.UnitPrice == max), Messages.ProductListed);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new DataResult<Product>(_productDal.Get(p => p.ProductId == productId),true);
        }

        public IResult Add(Product product)
        {
            //Business codes

            if (product.ProductName.Length < 2)
            {
                //Magic strings
                return new ErrorResult(Messages.ProductNameInValid);
            }
            _productDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);

            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
