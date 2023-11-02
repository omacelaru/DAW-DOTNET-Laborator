using DAW_DOTNET_Laborator.Models.Base;

namespace DAW_DOTNET_Laborator.Models.Many_to_Many
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }

        public List<Learn> learns { get; set; }

    }
}
