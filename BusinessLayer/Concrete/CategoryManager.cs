using BusinessLayer.Abstract;
using DataAccess.Abstract;
using Domain.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Constants;
using Core.Utilities.Results;
using FluentValidation;
using BusinessLayer.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;
        IValidator<Category> _validator;


        public CategoryManager(ICategoryDAL categoryDAL, IValidator<Category> validator)
        {
            _categoryDAL = categoryDAL;
            _validator = validator;
        }


        [ValidationAspect(typeof(CategoryValidator))]
        public IResult Add(Category category)
        {
            _categoryDAL.Add(category);

            return new SuccessResult(Messages.CategoryAdded);

        }

        public IDataResult<List<Category>> GetAll()
        {



            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<List<Category>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Category>>(_categoryDAL.GetAll(), Messages.CategoryListed);
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDAL.Get(c => c.CategoryId == categoryId));
        }
    }
}
