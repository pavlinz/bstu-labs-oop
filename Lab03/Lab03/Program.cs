using System;
using Lab01.Enemies;
using Lab01.Heros;
using Lab02.Creatures;
using Lab02.Hero.FriendlyHero;
using Lab02.Decorators;
using Lab02.Map;
using Lab03.Commands;
using Lab03.State;
using Lab03.Memento;

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



                string nameOfMap = "Пустыня";
                Map map = new Map(nameOfMap);

                map.Draw();

                map.AddComponent(myHero);

                IComponent component = map.Find("Main Hero");

                Console.WriteLine(component.Title);
                Console.WriteLine();

                // Lab03 start here

                GameHistory game = new GameHistory();

                Command jumpCommand = new JumpCommand(myHero);
                Command runCommand = new RunCommand(myHero);

                while(true)
                {
                    char Symbol = Char.Parse(Console.ReadLine());

                    if (Symbol == 'q')
                    {
                        jumpCommand.Execute();
                        myHero.HandleInput(Symbol);
                    }
                    else if (Symbol == 'w')
                    {
                        runCommand.Execute();
                        myHero.HandleInput(Symbol);
                    }
                    else if(Symbol == 's')
                    {
                        game.History.Push(myHero.SaveState());
                    }
                    else
                        break;
                }

                myHero.RestoreState(game.History.Pop());

                Console.ReadLine();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
