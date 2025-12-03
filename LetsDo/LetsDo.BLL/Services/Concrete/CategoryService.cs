using LetsDo.BLL.Services.Abstract;
using LetsDo.DAL.DataContext.Entities;
using LetsDo.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsDo.BLL.Services.Concrete
{
    public class CategoryService:GenericService<Category>, ICategoryService
    {
        public CategoryService(IGenericRepository<Category> repository) 
        :base(repository){ }
    }
}
