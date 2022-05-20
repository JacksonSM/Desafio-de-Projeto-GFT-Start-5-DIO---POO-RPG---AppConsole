using System;
using System.Collections.Generic;
using POO_RPG.Entities.Heros;
using POO_RPG.Entities.Enums;

namespace POO_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Hero> heroes = new List<Hero>(); 
            heroes.Add(new Ninja("Niko", 58, NinjaWeapon.NinjaStar));
            heroes.Add(new Knight("Torus", 62,KnightWeapon.Axe));
            heroes.Add(new WhiteWizard("Bela", 59, WizardMagic.PlasmaBeam));
            heroes.Add(new BlackWizard("Brutus", 60, WizardMagic.FireRay));

            foreach(Hero hero in heroes)
            {
                
                Console.WriteLine(hero);
                Console.WriteLine("==========================================");
            }
            Console.WriteLine("*****************Ataques******************");
            foreach (Hero hero in heroes)
            {

                Console.WriteLine(hero.Attack());
        
            }
            Console.ReadLine();
        }
       
    }
}
