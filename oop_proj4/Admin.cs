using System.Data.Linq.Mapping;

namespace oop_proj4
{

    [Table(Name = "Admin")]
    public class Admin
    {
        [Column(IsPrimaryKey = true)] public int Id { get; set; }
        [Column] public string Admin_id { get; set; }
        [Column] public string Admin_pw { get; set; }
    }
}
