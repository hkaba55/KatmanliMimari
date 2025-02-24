using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using BusinessLayer.Constants;
using BusinessLayer.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Domain.Concrete.Entity;
using Domain.DTOs;

namespace BusinessLayer.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDAL _productDal;

        public ProductManager(IProductDAL productDal)
        {
            _productDal = productDal;
        }

        public IDataResult<List<Product>> GetAll()
        {

            //fluent
            if (DateTime.Now.Hour == 13)
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


        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            //Business codes

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
