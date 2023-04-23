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
            // _breadCount = count;
        }
    }
}
