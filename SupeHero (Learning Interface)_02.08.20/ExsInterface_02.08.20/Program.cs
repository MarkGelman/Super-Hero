using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExsInterface_02._08._20
{
    class Program
    {
        static void Main(string[] args)
        {
           
            SuperMan superman = new SuperMan("Superman", 34, 220);
            SpiderMan spiderman = new SpiderMan ("Spiderman",41,137);
            Flash flash = new Flash ("Flash", 29, 1000);
            ISuperHero[] _heroes = { superman, spiderman, flash };

            foreach (ISuperHero hero in _heroes)
            {
                ActivateHero(hero);
                Console.WriteLine();

                GetMoreHeroData(hero);
                Console.WriteLine();
                
            }

            Console.WriteLine();
            Console.WriteLine();

            
            Console.WriteLine($"{CreateHero("Superman").GetName()}");
            Console.WriteLine();
            Console.WriteLine($"{CreateHero("Spiderman").GetName()}");
            Console.WriteLine();
            Console.WriteLine($"{CreateHero("Flash").GetName()}");

            Console.ReadKey();

        }
        static void ActivateHero (ISuperHero hero)
        {
            hero.ActivateSuperPowers();
        }

        static void IdentifyHero (ISuperHero hero)
        {
            if (hero is SuperMan)
                Console.WriteLine("Superman detected!!!");

            if (hero is SpiderMan)
                Console.WriteLine("Spiderman detected!!!");

            if (hero is Flash)
                Console.WriteLine("Flash detected!!!");
        }

        static void GetMoreHeroData(ISuperHero hero)
        {
            SuperMan superman;
            SpiderMan spiderman;
            Flash flash;
            if (hero is SuperMan)
            {
                superman = hero as SuperMan;
                Console.WriteLine($"Superman flying with speed : {superman.GetSpeed()}");
            }

            if (hero is SpiderMan)
            {
                spiderman = hero as SpiderMan;
                Console.WriteLine($"Spiderman climb with  {spiderman.GetWebleft()} web!");
            }


            if (hero is Flash)
            {
                flash = hero as Flash;
                Console.WriteLine($"Flash fire lightnings by voltage : {flash.GetVoltage()}");
            }
        }
        static Human CreateHero (string nameHero)
        {
            SpiderMan Spiderman;
            SuperMan Superman;
            Flash Flash;
            switch (nameHero)
            {
                case "Spiderman": return Spiderman = new SpiderMan("Spiderman1", 47, 281);
                case "Superman": return Superman = new SuperMan("Superman1",22,600);
                case "Flash": return Flash = new Flash ("Flash1", 43, 1000); 
            }
            return null;
        } 

 
    }
}
