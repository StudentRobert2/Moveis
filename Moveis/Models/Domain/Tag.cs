namespace Bloggie.Web.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
