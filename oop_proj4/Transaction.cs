using System;
using System.Data.Linq.Mapping;

namespace oop_proj4
{
    [Table(Name = "Transaction")]
    public class Transaction
    {
        [Flags]
        public enum EType { INCOME = 0, OUTCOME }
        public enum EPayType { CARD = 0, CASH  }

        [Column(IsPrimaryKey = true, IsDbGenerated = true)] public int Id { get; set; }

        [Column] public int MemberId { get; set; }
        [Column] public int Amount { get; set; }
        [Column] public DateTime Date { get; set; }
        [Column] public int Type { get; set; }
        [Column] public int PayMethod { get; set; }
        [Column] public string Memo { get; set; }

        public string ToStringDate()
        {
            if (Date != null)
                return Date.ToShortDateString();
            else
                return "날짜 없음";
        }

        public string ToStringAmount()
        {
            return Amount.ToString() + " 원";
        }

        public string ToStringType()
        {
            switch (Type)
            {
                case (int)EType.INCOME:
                    return "수입";
                    break;
                case (int)EType.OUTCOME:
                    return "지출";
                    break;
            }

            return "";
        }

        public string ToStringPayMethod()
        {
            switch (PayMethod)
            {
                case (int)EPayType.CARD:
                    return "카드";
                    break;
                case (int)EPayType.CASH:
                    return "현금";
                    break;
            }

            return "";
        }

    }
}