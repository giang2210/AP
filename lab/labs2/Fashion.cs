using T2008m.lab.labs1;

namespace T2008m.lab.labs2
{
    public class Fashion : Product
    {
        public string color;
        public string size;

        public bool CheckColorAndSize(string c, string s)
        {
            if (color.Equals(c) && size.Equals(s) && qty > 0)
                return true;
            return false;
        }
    }
}