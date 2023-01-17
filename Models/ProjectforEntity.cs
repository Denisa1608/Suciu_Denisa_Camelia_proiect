namespace Suciu_Denisa_Camelia_proiect.Models
{
    public class ProjectforEntity
    {
        public int ID { get; set; }
        public string ProjectforEntityName { get; set; }
        public ICollection<ProjectforEntity>? Books { get; set; }
    }
}
