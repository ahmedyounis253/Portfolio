namespace portfolio.pagging
{
    public class ObjectPaging
    {
        public int pageNumber { get; set; } = 1;
        public int _pageSize = 10;
        public const int maxSize = 10;
        public int pageSize { 
            get {

                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxSize) ? maxSize : value;
            }
        }



    }
}