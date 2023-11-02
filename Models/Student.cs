using DAW_DOTNET_Laborator.Models.Base;
using DAW_DOTNET_Laborator.Models.Many_to_Many;
using DAW_DOTNET_Laborator.Models.One_to_Many;
using DAW_DOTNET_Laborator.Models.One_to_One;

namespace DAW_DOTNET_Laborator.Models
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<Pen> pens { get; set; }

        public List<Learn> learns { get; set; }
    }
}
