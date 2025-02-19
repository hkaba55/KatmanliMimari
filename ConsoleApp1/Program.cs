// See https://aka.ms/new-console-template for more information
using BusinessLayer.Concrete;
using DataAccess.Concrete.EntityFramework;
using Domain.Concrete.Entity;
using System.Reflection.Metadata;

//Console.WriteLine("Hello, World!");


//UserManager userManager = new UserManager(new UserDAL());


// List < User > users = userManager.GetAllUser();

////userManager.Add(user);

//Console.WriteLine("kullanıcı listesi : ");

//foreach (var user in users)
//{
//    Console.WriteLine(user.userName);
//}

CategoryManager categoryManager = new CategoryManager(new CategoryDAL());
Category category = new Category
{
    CategoryName = "kitap"
};
categoryManager.categoryAdd(category);
Console.WriteLine("kategori oluşturldu" + category.CategoryName);

