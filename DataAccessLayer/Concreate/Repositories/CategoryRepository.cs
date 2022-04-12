using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.Repositories
{
    public class CategoryRepository : ICategoryDal
    {


        Context c=new Context();
        DbSet<Category> _object;
        public void Delete(Category p)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category p)
        {
            throw new NotImplementedException();
        }

        public List<Category> List()
        {
         return _object.ToList();

        }

        public void Update(Category p)
        {
            throw new NotImplementedException();
        }
    }
}
/*
 * 
 * ToList
 * Add
 * 
 
 
 */