using DAW_DOTNET_Laborator.Models.Base;

namespace DAW_DOTNET_Laborator.Models.One_to_One
{
    public class Address : BaseEntity
    {
        public Guid StudentId { get; set; }
        public string Street { get; set; }
        public Student Student { get; set; }
    }
}
