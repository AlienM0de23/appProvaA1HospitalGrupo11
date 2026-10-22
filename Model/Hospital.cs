using SQLite;
    
namespace appProvaA1HospitalGrupo11.Model
{
    [Table("Hospital")]
    public class Hospital
    {
        [PrimaryKey, AutoIncrement, Unique, NotNull]
        public int hosID { get; set; }
        
        [MaxLength(1000)]
        public string? hosNome { get; set; }
  
        [MaxLength(1000)]
        public string? hosEndereco { get; set; }
    }
}
