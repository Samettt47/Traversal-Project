using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        Context context = new Context(); // Contexten iglili id ye ait veriyi bul (guide rehber'i bul ) 
        public void ChangeToFalseByGuide(int id)
        {            
            var values = context.Guides.Find(id); // ve bulduğun bu rehberi false yap
            values.Status = false;
            context.Update(values);
            context.SaveChanges();
        }

        public void ChangeToTrueByGuide(int id)
        {         
            var values = context.Guides.Find(id); // ve bulduğun bu rehberi true yap
            values.Status = true;
            context.Update(values);
            context.SaveChanges();
        }
    }
}
