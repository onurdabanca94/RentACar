using Core.Persistance.Repositories;

namespace Domain.Entities;

public class Brand : Entity<Guid>
{
    public string Name { get; set; }

    public virtual ICollection<Model> Models { get; set; } //virtual sebebi farklı ORM'ler ile çalışıldığında kolaylık sağlaması için.(NHibernete vb.)

    public Brand()
    {
        Models = new HashSet<Model>();
    }

    public Brand(Guid id, string name) : this()
    {
        Id = id;
        Name = name;
    }
}
