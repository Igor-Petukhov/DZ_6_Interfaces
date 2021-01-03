using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6_Interfaces
{
    
    class House : IPart
    {
        //Счётчики готовых элементов
        public int CounterBasement { get; set; }
        public int CounterWalls { get; set; }
        public int CounterDoors { get; set; }
        public int CounterWindows { get; set; }
        public int CounterRoof { get; set; }

        //Запланировано элементов
        public int NeedBasement { get; }
        public int NeedWalls { get; }
        public int NeedDoors { get; }
        public int NeedWindows { get; }
        public int NeedRoof { get; }

        public House(int BasementToDo, int WallsToDo, int DoorsToDo, int WindowsToDo, int RoofToDo)//Вносим план здания. Сколько надо в итоге получить фундамента, стен и т.д.
        {
            CounterBasement = 0;
            CounterWalls = 0;
            CounterDoors = 0;
            CounterWindows = 0;
            CounterRoof = 0;

            this.NeedBasement = BasementToDo;
            this.NeedWalls = WallsToDo;
            this.NeedDoors = DoorsToDo;
            this.NeedWindows = WindowsToDo;
            this.NeedRoof = RoofToDo;
        }

        public bool IsReady()
        {
            if (IsBasementReady() && IsWallsReady() && IsDoorsReady() && IsWindowsReady() && IsRoofReady())
            {
                Console.WriteLine("House is ready!");
                return true;
            }
            else
            {
                Console.WriteLine("House is NOT ready!");
                return false;
            }
        }
        public bool IsBasementReady()
        {
            if (CounterBasement == NeedBasement)
            {
                Console.WriteLine("Basement is ready!");
                return true;
            }
            else
            {
                Console.WriteLine("Basement is NOT ready!");
                return false;
            }
        }
        public bool IsWallsReady()
        {
            if (CounterWalls == NeedWalls)
            {
                Console.WriteLine("Walls are ready!");
                return true;
            }
            else
            {
                Console.WriteLine("Walls are NOT ready!");
                return false;
            }
        }
        public bool IsDoorsReady()
        {
            if (CounterDoors == NeedDoors)
            {
                Console.WriteLine("Doors are ready!");
                return true;
            }
            else
            {
                Console.WriteLine("Doors are NOT ready!");
                return false;
            }
        }
        public bool IsWindowsReady()
        {
            if (CounterWindows == NeedWindows)
            {
                Console.WriteLine("Windows are ready!");
                return true;
            }
            else
            {
                Console.WriteLine("Windows are NOT ready!");
                return false;
            }
        }
        public bool IsRoofReady()
        {
            if (CounterRoof == NeedRoof)
            {
                Console.WriteLine("Roof is ready!");
                return true;
            }
            else
            {
                Console.WriteLine("Roof is NOT ready!");
                return false;
            }
        }
        public void Create()
        {
            Console.WriteLine("Start building house...");
        }
    }

    class Basement : IPart
    {
        House house;
        public Basement(House myHouse)
        {
            house = myHouse;
        }
        public void Create()
        {
            Console.WriteLine("Building Basement...");
            house.CounterBasement++;
        }
        public bool IsReady()
        {
            return house.CounterBasement == house.NeedBasement;
        }
    }
    class Wall : IPart
    {
        House house;
        public Wall(House myHouse)
        {
            house = myHouse;
        }
        public void Create()
        {
            Console.WriteLine("Building a Wall...");
            house.CounterWalls++;
        }
        public bool IsReady()
        {
            return house.CounterWalls == house.NeedWalls;
        }
    }
    class Window : IPart
    {
        House house;
        public Window(House myHouse)
        {
            house = myHouse;
        }
        public void Create()
        {
            Console.WriteLine("Building a Window...");
            house.CounterWindows++;
        }
        public bool IsReady()
        {
            return house.CounterWindows == house.NeedWindows;
        }
    }
    class Door : IPart
    {
        House house;
        public Door(House myHouse)
        {
            house = myHouse;
        }
        public void Create()
        {
            Console.WriteLine("Building a Door...");
            house.CounterDoors++;
        }
        public bool IsReady()
        {
            return house.CounterDoors == house.NeedDoors;
        }
    }
    class Roof : IPart
    {
        House house;
        public Roof(House myHouse)
        {
            house = myHouse;
        }
        public void Create()
        {
            Console.WriteLine("Building a Roof...");
            house.CounterRoof++;
        }
        public bool IsReady()
        {
            return house.CounterBasement == house.NeedBasement;
        }
    }
}
