using System;

namespace T2008m.PRACTICAL.Exercise_2
{
    public class Tiger : Base
    {
        public Tiger() : base()
        {
        }

        public Tiger(double Weight, string Name) : base(Weight, Name)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Name: " + this.Name + ", Weight " + this.Weight);
        }

        public override void SetMe(double weight, string Name)
        {
            this.Weight = Weight;
            this.Name = Name;
        }
    }
}