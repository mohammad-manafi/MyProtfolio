namespace MyPortfolio.Models
{
    public class Project
    {
        public long id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public string Client { get; set; }

        public Project(long id, string name, string description, string image, string client)
        {
            this.id = id;
            Name = name;
            Description = description;
            Image = image;
            Client = client;
        }
    }
}
