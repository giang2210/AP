using System;

namespace T2008m.PRACTICAL.Exercise_2
{
    public class Lion : Base
    {
        public Lion()
        {
        }
        public Lion(double Weight, string Name) : base(Weight, Name)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Name: " + this.Name + ", Weight " + this.Weight);
        }

        public override void SetMe(double Weight, string Name)
        {
            this.Weight = Weight;
            this.Name = Name;
        }

    }
}