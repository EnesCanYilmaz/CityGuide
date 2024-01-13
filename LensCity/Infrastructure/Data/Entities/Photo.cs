namespace LensCity.Infrastructure.Data.Entities;

public abstract class Photo : BaseEntity
{
    public int CityId { get; set; }
    public string FileName { get; set; }
    public string Path { get; set; }
    public DateTime CreatedDate { get; set; }
    
    //Relationships
    public City City { get; set; }
    public AppUser User { get; set; }
    
    
}