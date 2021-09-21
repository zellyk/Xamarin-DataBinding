using System;
namespace DataBinding
{
    public class Fruit
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {

            return Name + " " + Color;
        }

    }
}
