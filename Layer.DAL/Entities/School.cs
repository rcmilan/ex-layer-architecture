namespace Layer.DAL.Entities
{
    public class School : BaseEntity<int>
    {
        private School()
        {

        }

        public School(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
