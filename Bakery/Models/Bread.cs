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

        public int GetCost()
        {
            int cost = 0;
            return cost;
        }
    }
}