using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseFirst.CRUDOperation;
namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //AreaCRUD 

            int option, id;
            do
            {
                Console.WriteLine("Please select an option \n 1: Add a record \n 2: Read all Records \n 3:Update a Record \n 4: Delete a Record");
                Console.WriteLine("Enter your option in number");
                option = Convert.ToInt32(Console.ReadLine());
                AreaCRUD areaCRUD = new AreaCRUD();
                switch (option)
                {
                    case 1: //Add a Record
                        Console.WriteLine("Enter the area name:");
                        string AreaName = Console.ReadLine();
                        Console.WriteLine("Enter the City Id:");
                        int CityId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Area Pincode");
                        string Pincode = Console.ReadLine();
                        areaCRUD.AreaName = AreaName;
                        areaCRUD.CityId = CityId;
                        areaCRUD.Pincode = Pincode;
                        areaCRUD.CreateRecord();
                        break;
                    case 2: //Read all Records
                        areaCRUD.ReadRecords();
                        break;
                    case 3: //Update a Record
                        Console.Write("Enter Area ID you want to Update: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        areaCRUD.AreaId = id;
                        areaCRUD.UpdateRecord();
                        break;
                    case 4: //Delete a Record
                        Console.Write("Enter Area ID you want to Delete: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        areaCRUD.AreaId = id;
                        areaCRUD.DeleteRecord();
                        break;
                    case 5:
                        Console.WriteLine("This is not a valid option");
                        break;
                    default:
                        Console.WriteLine("This is not a valid option");
                        break;

                }
            } while (option != 5);
                   

        }
    }
}
