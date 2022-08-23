using Business.Concrete;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new InMemoryCarDal());

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.CarId);
}

foreach (var car in carManager.GetById(2))
{
    Console.WriteLine(car.CarId);
}
