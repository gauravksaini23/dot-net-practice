using Practice.CompositPattern.Providers;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.CompositPattern.Factory
{
    public class Composite : Component
    {
        List<Component> components = new List<Component>();
        public Composite(string name) : base(name) { }
        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + _name);
            foreach (var component in components)
            {
                component.Display(depth + 2);
            }
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }
    }
}
