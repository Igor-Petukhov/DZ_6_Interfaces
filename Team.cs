using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6_Interfaces
{
    class Team : IWorker
    {
        List<IWorker> A;
        House house;
        Basement basement;
        Wall walls;
        Door door;
        Window windows;
        Roof roof;
        public Team(List<IWorker> a)
        {
            A = a;
            Work(a);
            Check(a);
        }

        public bool Check()
        {
            return false;
        }
        public bool Check(List<IWorker> a)
        {
            Console.WriteLine("Мы бригада и мы проверяем...");
            Random rnd = new Random();
            a[rnd.Next(0, a.Count)].Check();
            return true;
        }

            public void Work()
        {
            Console.WriteLine("Мы бригада и мы работаем...");
        }
        public void Work(List<IWorker> a)
        {
            Console.WriteLine("Мы бригада и мы работаем...");
            Check(a);
        }
    }

    class Worker : IWorker
    {
        protected string name;
        protected House house;
        protected Basement basement;
        protected Wall walls;
        protected Door door;
        protected Window windows;
        protected Roof roof;
        public Worker(string name, House buildHouse, Basement basement, Wall walls, Door door, Window windows, Roof roof)
        {
            this.name = name;
            this.house = buildHouse;
            this.basement = basement;
            this.walls = walls;
            this.door = door;
            this.windows = windows;
            this.roof = roof;
        }
        public bool Check()
        {
            Console.WriteLine($"Привет. Меня зовут {name}. Я воркер и я проверяю.");
            if (house.IsReady())
            {
                Console.WriteLine("House is ready! Work is done. Give me money!");
                return true;
            }
            else
            {
                if (house.IsBasementReady())
                {
                    if (house.IsWallsReady())
                    {
                        if (house.IsWindowsReady())
                        {
                            if (house.IsDoorsReady())
                            {
                                if (house.IsRoofReady())
                                {
                                    Console.WriteLine("You will never see this text. I hope.");
                                }
                                else
                                {
                                    Work(roof);
                                }
                            }
                            else
                            {
                                Work(door);
                            }
                        }
                        else
                        {
                            Work(windows);
                        }
                    }
                    else
                    {
                        Work(walls);
                    }
                }
                else
                {
                    Work(basement);
                }
                return false;
            }
        }
        public void Work()
        {
        }
        public void Work(IPart part_to_do)
        {
            Console.WriteLine($"Привет. Меня зовут {name} я воркер и регламент работ меня заставил сказать, что я сейчас работаю...");
            part_to_do.Create();
        }
    }

    class TeamLeader : IWorker
    {
        protected string name;
        protected House house;
        protected Basement basement;
        protected Wall walls;
        protected Door door;
        protected Window windows;
        protected Roof roof;
        public TeamLeader(string name, House buildHouse, Basement basement, Wall walls, Door door, Window windows, Roof roof)
        {
            this.name = name;
            this.house = buildHouse;
            this.basement = basement;
            this.walls = walls;
            this.door = door;
            this.windows = windows;
            this.roof = roof;
        }
        public bool Check()
        {
            Console.WriteLine($"Привет. Меня зовут {name}. Я бригадир и я проверяю.");
            if (house.IsReady())
            {
                Console.WriteLine("House is ready! Work is done. Give me money!");
                return true;
            }
            else
            {
                if (house.IsBasementReady())
                {
                    if (house.IsWallsReady())
                    {
                        if (house.IsWindowsReady())
                        {
                            if (house.IsDoorsReady())
                            {
                                if (house.IsRoofReady())
                                {
                                    Console.WriteLine("You will never see this text. I hope.");
                                }
                                else
                                {
                                    Console.WriteLine("Need to build a roof."); ;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Need to build a door."); ;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Need to build a window."); ;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Need to build a wall."); ;
                    }
                }
                else
                {
                    Console.WriteLine("Need to build basement."); ;
                }
                return false;
            }
        }
        public void Work()
        {
            Console.WriteLine($"Привет. Меня зовут {name}. Я Бригадир! И регламент работ меня заставил сказать, что я сейчас работаю...");
            Check();
        }

    }
}
