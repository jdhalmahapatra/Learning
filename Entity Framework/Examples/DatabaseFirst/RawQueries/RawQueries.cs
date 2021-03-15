using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst.RawQueries
{
    class RawQueries
    {
        static void Main(string[] args)
        {
           
            using (var db = new LocationEntities())
            {

                /*Writing SQL Queries for Entity Type*/
                //string sql = "select * from Areas where CityId = 2";
                Console.WriteLine("---------------SQL Queries for Entity type-------------------");
                SqlParameter p = new SqlParameter();
                p.ParameterName = "@Id";
                p.Value = 2;
                p.SqlDbType = System.Data.SqlDbType.Int;
                string sql = "select * from Areas where CityId = @Id";
                IEnumerable<Area> areaList =db.Areas.SqlQuery(sql, p);
                foreach(Area a in areaList)
                {
                    Console.WriteLine("{0}\t {1}\t", a.AreaName, a.City.CityName);
                }

                /*Writing SQL Queries for Non-Enity type*/
                Console.WriteLine("---------------SQL Queries for Non-Entity type-------------------");
                sql = "select AreaName, Pincode from Areas";
                IEnumerable<MyArea>myAreaList = db.Database.SqlQuery<MyArea>(sql);
                foreach(MyArea area in myAreaList)
                {
                    Console.WriteLine("{0}\t{1}", area.AreaName, area.Pincode);
                }

                /*Writing SQL Non-Queries(Update, Insert, Delete) for Database */
                Console.WriteLine("---------------RAW Command/ SQL Non-Queries(Update, Delete, Insert) for Non-Entity type-------------------");
                sql = "Update Areas set Pincode='766777' where AreaId = 5";
                int r = db.Database.ExecuteSqlCommand(sql);
                if(r==1)
                    Console.WriteLine("Record updated");
                else
                    Console.WriteLine("Error in Executing Query");
            }
            Console.WriteLine("Please press any key to exist");
            Console.ReadKey();
        }
    }
}
