namespace QueryCollectionbyLINQLibrary
{
    public class Brand
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Brand(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
