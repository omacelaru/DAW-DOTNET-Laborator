namespace DAW_DOTNET_Laborator.Models.Many_to_Many
{
    public class Learn
    {
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
        public Guid SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
