using System;
using System.Collections.Generic;
using System.Data.SQLite;

public class Program {
  public static void Main(string[] args) {
        SQLiteConnection sqlite_conn;
        string myName = "Naomi Hammonds";
        Console.WriteLine($"{Naomi Hammonds}, Wk 2 PA Interface\n");
        //create two cars
        Car car = new Car("Kia", "Stinger");
        Bike bike = new Bike("Harley", "Low Rider ST");

        vehicles.Add(car);
        vehicles.Add(bike);

        Console.WriteLine("Vehicles Print From The List");
        Console.WriteLine("===\n"); foreach (Car car in car) {
            Print(car);
        }
        Console.WriteLine("Vehicles Print From The List");
        Console.WriteLine("===\n"); foreach (Bike bike in bike) {
            Print(bike);
        }

        Print(Car);
        Print(Bike);
}
        static SQLiteConnection CreateConnection(){}
        private static void Print(Vehicle vehicle) {
            Console.WriteLine(vehicle);
            Console.WriteLine();
        }
}