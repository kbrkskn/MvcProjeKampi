using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>//T bir Entity ye den geliyor burada ne gönderirsek o olacak
    {

        //Bu işlem sayesinde tek tek her bir tablo için interface tanımlamamıza gerek kalmadı
        List<T> List();
        void Insert(T p);
        void Update(T p);
        void Delete(T p);

        List<T> List(Expression<Func<T, bool>> filter);//Bu method sayesinde şartlı listeleme yapabileceğiz!!
    }
}
