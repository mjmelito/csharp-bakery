namespace Bakery.Models
{
    public class Pastry
    {
        private int _pastryCount;
        public int PastryCount
        {
            get {return _pastryCount; }
            set {_pastryCount = value; }
        }
        public Pastry(int count)
        {
            _pastryCount = count;
        }
        public decimal GetCost()
        {
            decimal cost = 0;
            int freePastries = _pastryCount / 4;
            cost = (_pastryCount - freePastries) * 2;
            return cost;
        }
    }
}
