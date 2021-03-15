using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.AutomaticChangeTracking
{
    class AutoChangeTracking
    {
        static void Main(string[] args)
        {
            using (var db = new LocationEntities())
            {
                Area newArea = new Area()
                {
                   AreaName = "Jatin Nagar",
                   CityId = 2,
                   Pincode = "487005"
                };
                db.Areas.Add(newArea);
                Console.WriteLine("After add a new record");
                foreach(var tracker in db.ChangeTracker.Entries<Area>())
                {
                    Console.WriteLine(tracker.State);
                }

                Area modifiedArea = db.Areas.Find(2);
                modifiedArea.Pincode = "234470";
                Console.WriteLine("After Modificatiton");
                foreach (var tracker in db.ChangeTracker.Entries<Area>())
                {
                    Console.WriteLine(tracker.State);
                }
                Area toBeDeletedArea = db.Areas.Find(8);
                if(toBeDeletedArea != null)
                    db.Areas.Remove(toBeDeletedArea);
                
                Console.WriteLine("After Delete");
                foreach (var tracker in db.ChangeTracker.Entries<Area>())
                {
                    Console.WriteLine(tracker.State);
                }
                db.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}
