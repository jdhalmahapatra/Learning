using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.CRUDOperation
{
    public class AreaCRUD
    {
        public string AreaName { get; set; }
        public int CityId { get; set; }
        public string Pincode { get; set; }
        protected internal int AreaId { get; set; }

        public void CreateRecord()
        {
            using (var db = new LocationEntities())
            {
                var area = new Area()
                {
                    AreaName = AreaName,
                    CityId = CityId,
                    Pincode = Pincode
                };
                db.Areas.Add(area);
                db.SaveChanges();
            }
        }
        public void ReadRecords()
        {
            using (var db = new LocationEntities())
            {
                //WithOut using Join
                var query = from a in db.Areas select a;

                //With Using Join
                //var query = from a in db.Areas
                //             join c in db.Cities on a.CityId equals c.CityId
                //             select new
                //             {
                //                 a.AreaId,
                //                 a.AreaName,
                //                 c.CityName,
                //                 a.Pincode
                //             };


                foreach(var item in query)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", item.AreaId, item.AreaName, item.City.CityName, item.Pincode);
                }
            }
        }
        public void UpdateRecord()
        {
            using (var db = new LocationEntities())
            {
                Area areaObj = db.Areas.Find(AreaId);
                if(areaObj == null)
                    Console.WriteLine("Invlaid Area Id, Try Again");
                else
                {
                    Console.WriteLine("Enter Area Name to update:");
                    areaObj.AreaName = Console.ReadLine();
                    Console.WriteLine("Enter City Id to update: ");
                    areaObj.CityId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Pincode to Update: ");
                    areaObj.Pincode = Console.ReadLine();
                    db.SaveChanges();
                }
            }
        }
        public void DeleteRecord()
        {
            using (var db = new LocationEntities())
            {
                Area areaObj = db.Areas.Find(AreaId);
                if (areaObj == null)
                    Console.WriteLine("Invlaid Area Id, Try Again");
                else
                {
                    db.Areas.Remove(areaObj);
                    db.SaveChanges();
                }
            }
        }
    }
}
