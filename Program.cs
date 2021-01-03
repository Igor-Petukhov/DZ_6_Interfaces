using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House(1, 4, 1, 4, 1);
            Basement basement = new Basement(house);
            Wall wall = new Wall(house);
            Door door = new Door(house);
            Window windows = new Window(house);
            Roof roof = new Roof(house);
            Worker w1 = new Worker("Равшан", house, basement, wall, door, windows, roof);
            Worker w2 = new Worker("Джамшут", house, basement, wall, door, windows, roof);
            Worker w3 = new Worker("Брат Равшана", house, basement, wall, door, windows, roof);
            Worker w4 = new Worker("Сестра Равшана", house, basement, wall, door, windows, roof);
            TeamLeader w5 = new TeamLeader("Майонез Петрович", house, basement, wall, door, windows, roof);
            List<IWorker> team = new List<IWorker>() { w1, w2, w3, w4, w5};
            Team BUILDING = new Team(team);
            BUILDING.Work(team);
            BUILDING.Work(team);
            BUILDING.Work(team);
            BUILDING.Work(team);
            BUILDING.Work(team);
            BUILDING.Work(team);
            BUILDING.Work(team);
            BUILDING.Work(team);
            BUILDING.Work(team);
            BUILDING.Work(team);
            BUILDING.Work(team);
            BUILDING.Work(team);
            BUILDING.Work(team);
            BUILDING.Work(team);
            BUILDING.Work(team);
            //Если бригадир будет часто выпадать, то может потребоваться больше подходов к работе


            Console.ReadKey();
        }
    }
}
