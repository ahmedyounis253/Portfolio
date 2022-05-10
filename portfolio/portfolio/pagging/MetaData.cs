namespace portfolio.pagging
{
    public class MetaData
    {

        public int pageNumber { get; set; }
        public int pageSize { get; set; } = 4;
        public int totalPages { get; set; }
        public int totalCount { get; set; }
        public bool hasPrevious => pageNumber > 1;
        public bool hasNext => pageNumber < totalPages;

    }
}
