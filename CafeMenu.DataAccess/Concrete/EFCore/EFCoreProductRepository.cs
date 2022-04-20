using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.DataAccess.Abstract;
using TaskManager.Entity;

namespace TaskManager.DataAccess.Concrete.EFCore
{
    public class EFCoreProductRepository:EFCoreGenericRepository<Product,TaskManagerContext>,IProduct
    {
    }
    public class EFCoreCategoryRepository:EFCoreGenericRepository<Category,TaskManagerContext>,ICategory
    {
    }
    public class EFCoreUserRepository:EFCoreGenericRepository<User,TaskManagerContext>,IUser
    {
    }
    public class EFCorePropertyRepository:EFCoreGenericRepository<Property,TaskManagerContext>,IProperty
    {
    }
    public class EFCoreProductPropertyRepository:EFCoreGenericRepository<ProductProperty,TaskManagerContext>,IProductProperty
    {
    }
}
