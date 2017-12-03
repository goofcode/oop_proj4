using System;
using System.Data.Linq.Mapping;

namespace oop_proj4
{
    [Table(Name = "Member")]
    public class Member
    {
        [Flags]
        enum EGender { Male = 1, Female = 2 }
        enum ERegistrationState { Doing = 0, Stop = 1, Quit = 2 }

        [Column(IsPrimaryKey = true, IsDbGenerated = true)] public int Id { get; set; }
        [Column] public string Name { get; set; }
        [Column] public string Tel { get; set; }
        [Column] public int Gender { get; set; }
        [Column] public DateTime BirthDate { get; set; }
        [Column] public int RegisterationState { get; set; }
        [Column] public DateTime EndDate { get; set; }
        [Column] public DateTime RegisterationDate { get; set; }
        [Column] public string Memo { get; set; }

        public string ToStringGender()
        {
            if (Gender == (int)EGender.Male)
            {
                return "남자";
            }
            else if (Gender == (int)EGender.Female)
            {
                return "여자";
            }

            return "외계인";
        }

        public string ToStringRegistrationState()
        {
            if (RegisterationState == (int)ERegistrationState.Doing)
            {
                return "등록";
            }
            else if (RegisterationState == (int)ERegistrationState.Stop)
            {
                return "정지";
            } 
            else if (RegisterationState == (int)ERegistrationState.Quit)
            {
                return "탈퇴";
            }

            return "스파이";
        }
        
    }
}
