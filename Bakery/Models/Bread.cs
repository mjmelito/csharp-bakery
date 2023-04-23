namespace Bakery.Models
{
    public class Bread
    {
        private int _breadCount;
        public int BreadCount
        {
            get {return _breadCount; }
            set {_breadCount = value; }
        }

        public Bread(int count)
        {
            _breadCount = count;
        }

        public decimal GetCost()
        {
            decimal cost = 0;
            int freeLoaves = _breadCount / 3;
            cost = (_breadCount - freeLoaves) * 5;
            return cost;
        }
    }
}