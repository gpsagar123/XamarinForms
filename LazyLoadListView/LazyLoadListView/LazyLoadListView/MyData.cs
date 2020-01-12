using SQLite;

namespace LazyLoadListView
{
    public class MyData
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
    }
}