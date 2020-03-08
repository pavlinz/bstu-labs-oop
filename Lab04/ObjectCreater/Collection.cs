using System;
using System.Collections.Generic;
using System.Threading;

namespace ObjectCreater
{
    public class Collection
    {
        public List<Circle> list = new List<Circle>();

        public int count;

        public List<Circle> descendingSort()
        {
            list.Sort();
            list.Reverse();
            return list;
        }

        public List<Circle> ascendingSort()
        {
            list.Sort();
            return list;
        }

        public void AddElement(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Random rnd = new Random();
                int value = rnd.Next(1, 50);
                list.Add(new Circle(value));
                Thread.Sleep(5);
            }
        }

        public Collection(int amount)
        {
            for(int i = 0; i < amount; i++)
            {
                Random rnd = new Random();
                int value = rnd.Next(1, 50);
                list.Add(new Circle(value));
                Thread.Sleep(5);
                count++;
            }
        } 
    }
}
