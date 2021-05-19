using T2008m.lab.labs1;

namespace T2008m.lab.labs2
{
    public class Diamon : Product
    {
        public int cara;

        public bool CheckAuth()
        {
            if (cara > 10)
                return true;
            return false;
        }
    }
}