namespace BulkyBookWeb.Models
{
    public class Category
    {
       
        public int MyProperty { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
