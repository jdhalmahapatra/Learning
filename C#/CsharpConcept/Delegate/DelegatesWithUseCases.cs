using System;
using System.Collections.Generic;
using System.Text;

/*This Use case demonstatres the delegate usage to determine the Top Cars in the market. 
 * This is an example of Single Cast Delegate*/
namespace Delegate
{
   public enum Type{
        Automatic =0,
        Manual
    }
    class DelegatesWithUseCases
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car() {Model="Figo Aspire", Makers="Ford", Variant=Type.Manual, CarOnRoadPrice= 700000, EngineWarrantyYears=5, Mileage=20});
            cars.Add(new Car() { Model = "Kwid", Makers = "Renault", Variant = Type.Manual, CarOnRoadPrice = 300000, EngineWarrantyYears = 5, Mileage = 24 });
            cars.Add(new Car() { Model = "Amaze", Makers = "Honda", Variant = Type.Automatic, CarOnRoadPrice = 870000, EngineWarrantyYears = 1, Mileage = 15 });
            cars.Add(new Car() { Model = "Baleno", Makers = "Maruti Suzuki", Variant = Type.Automatic, CarOnRoadPrice = 700000, EngineWarrantyYears = 3, Mileage = 19 });
            cars.Add(new Car() { Model = "Seltos", Makers = "Kia", Variant = Type.Manual, CarOnRoadPrice = 600000, EngineWarrantyYears = 5, Mileage = 22 });
            cars.Add(new Car() { Model = "i20", Makers = "Hyundai", Variant = Type.Automatic, CarOnRoadPrice = 700000, EngineWarrantyYears = 5, Mileage = 25 });
            cars.Add(new Car() { Model = "Yaris", Makers = "Toyota", Variant = Type.Automatic, CarOnRoadPrice = 1500000, EngineWarrantyYears = 2, Mileage = 12 });

            CarRankingDelegate carRankingDel = new CarRankingDelegate(Top5RankingCars);
            Car.Top5CarsAccordingToRank(cars, carRankingDel);
        }
        static bool Top5RankingCars(Car car)
        {
            if (car.CarOnRoadPrice <= 800000 && car.Mileage >= 17 && car.EngineWarrantyYears >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


   delegate bool CarRankingDelegate(Car car); 
   class Car
    {
        public string Model { get; set; }
        public string Makers { get; set; }
        public Type Variant { get; set; }
        public double CarOnRoadPrice { get; set; }
        public int EngineWarrantyYears { get; set; }
        public int Mileage { get; set; }

        public static void Top5CarsAccordingToRank(List<Car> cars, CarRankingDelegate carRanking)
        {
            foreach(Car car in cars)
            {
               
                if(carRanking(car))
                {
                    Console.WriteLine
                        ("Best Car in the market is {0} from {1} of type {2}, it costs around Rs {3} lakhs on road. It has mileage {4} Kms and its engine warranty is {5} years \n", 
                            car.Model, 
                            car.Makers,
                            car.Variant,
                            car.CarOnRoadPrice,
                            car.EngineWarrantyYears,
                            car.Mileage
                        );
                }
            }
            Console.ReadKey();
        }
    }
}
