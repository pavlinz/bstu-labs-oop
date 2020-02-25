using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Map
{
    public class Map : IComponent
    {
        private readonly List<IComponent> _map = new List<IComponent>();

        public Map(string title)
        {
            Title = title;
        }

        public string Title { get; set; }

        public void AddComponent(IComponent component)
        {
            _map.Add(component);
        }

        public void Draw()
        {
            Console.WriteLine("Название карты: " + Title);
            foreach(IComponent component in _map)
            {
                Console.WriteLine(component.Title);
            }
        }

        public IComponent Find(string title)
        {
            foreach(IComponent component in _map)
            {
                if(component.Title == title)
                {
                    return component;
                }
            }
            return null;
        }
    }
}
