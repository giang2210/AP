namespace T2008m.PRACTICAL.Exercise_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var tiger = new Tiger(100, "Tiger");
            var lion = new Lion(200, "Lion");
            
            tiger.Show();
            lion.Show();
        }
    } 
}
