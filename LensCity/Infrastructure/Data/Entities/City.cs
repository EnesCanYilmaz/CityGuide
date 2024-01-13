namespace LensCity.Infrastructure.Data.Entities;

public abstract class City : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    
    //Relationships
    public List<Photo> Photos { get; set; } = []; 
}