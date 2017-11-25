using System;
using System.Data.Linq.Mapping;

namespace oop_proj4
{
    [Table(Name = "Member")]
    public class Member
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)] public int Id { get; set; }
        [Column] public string Name { get; set; }
        [Column] public int Gender { get; set; }
        [Column] public DateTime BirthDate { get; set; }
        [Column] public int RegisterationState { get; set; }
        [Column] public int LeftDay { get; set; }
        [Column] public string Memo { get; set; }
    }
}
