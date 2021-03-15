using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.EagerLoading
{
    class EagerLoading
    {
        static void Main(string[] args)
        {
            using (var db = new LocationEntities())
            {
                foreach(City cobj in db.Cities.Include("Areas"))
                {
                    Console.WriteLine("{0}", cobj.CityName);
                    foreach(Area aobj in cobj.Areas)
                    {
                        Console.WriteLine("{0}\t {1}\t {2}\t", aobj.AreaId, aobj.AreaName, aobj.Pincode);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
