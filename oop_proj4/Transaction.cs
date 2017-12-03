using System;
using System.Data.Linq.Mapping;

namespace oop_proj4
{
    [Table(Name = "Transaction")]
    public class Transaction
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)] public int Id { get; set; }
        [Column] public string MemberId { get; set; }
        [Column] public DateTime Date { get; set; }
        [Column] public int Type { get; set; }
        [Column] public int PayMethod { get; set; }
        [Column] public string Memo { get; set; }
    }
}