using DAW_DOTNET_Laborator.Models.Base;

namespace DAW_DOTNET_Laborator.Models.One_to_Many
{
    public class Pen : BaseEntity
    {
        public string Color { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }

    }
}
