using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {











        //CRUD
        //Type Name(); Metotlar böyle tanımlanır
        List<Category> List();

        void Insert(Category p);//p ile Category sınıfında yer alan propertylere ulaşabileceğim 

        void Update(Category p);

        void Delete(Category p);


        //CRUD operasyonlarının gerçekleşeceği metotları tanımladık
    }
}
 