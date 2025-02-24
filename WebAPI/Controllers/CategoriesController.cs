using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccess.Concrete.EntityFramework;
using Domain.Concrete.Entity;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        //Loosely Coupled
        //Naming convention,
        //IoC Container  --  Inversion of Control 
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public List<Category> Get()
        {
            //Dependenciy Chain --
            

           var result = _categoryService.GetAll();

           return result.Data;
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            var result = _categoryService.Add(category);

            if (! result.Success)
            {
                return BadRequest(result);
            }
            
            return Ok(result);
        }
    }
}
