namespace T2008m.PRACTICAL.Exercise_2
{
    public abstract class Base
    {
                protected double Weight;
                protected string Name;
        
                protected Base()
                {
                }
        
                protected Base(double Weight, string Name)
                {
                    this.Weight = Weight;
                    this.Name = Name;
                }
        
                public abstract void Show();
                public abstract void SetMe(double Weight, string Name);
            }
        }
