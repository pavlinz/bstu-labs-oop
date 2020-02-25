﻿using System;
using Lab01.Enemies;
using Lab01.Heros;
using Lab02.Creatures;
using Lab02.Hero.FriendlyHero;
using Lab02.Decorators;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Director director = new Director();

                HeroBuilder builder = new ElfHeroBuilder();

                Hero myHero = director.create(builder);

                Console.WriteLine(myHero.ToString());

                IHero friendlyHero = myHero.Clone();

                Console.WriteLine(friendlyHero.ToString());

                Console.Write("Введите кол-во создаваемых объектов -> ");
                var counter = int.Parse(Console.ReadLine());

                Console.Write("Введите тип создаваемых объектов ( 1 - пешие воины, 2 - всадники ) -> ");
                var type = int.Parse(Console.ReadLine());
                if (type != 1 && type != 2)
                    throw new Exception("Введен неверный тип юнита");

                ArmyOfEnemies army = new ArmyOfEnemies();

                if (type == 1) {

                    for (int i = 0; i < counter; i++) {

                        army.AddNewEnemy(new Unit(new FootEnemyFactory()));
                    }
                }
                else if (type == 2) {

                    for (int i = 0; i < counter; i++) {

                        army.AddNewEnemy(new Unit(new EquestrianEnemyFactory()));
                    }
                }

                foreach (var item in army.list) {

                    Console.WriteLine(item.ToString());
                }

                // Lab02 start here

                Console.WriteLine();
                Console.WriteLine();


                Horse horse = new Horse();

                myHero.Move(horse);

                Ally ally = new Ally();

                AllyAdapter adapter = new AllyAdapter(ally);

                myHero.Move(adapter);



                Personage personage = new ElfPersonage();

                Console.WriteLine(personage.Name);

                personage = new ExtraArmorPers(personage);

                Console.WriteLine(personage.Name);




                Console.ReadLine();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
