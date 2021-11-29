using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationManagement
{
    class BeneficiaryInfo
    {
        private static int autoIncrementRegNo = 1000;

        public int RegistrationNumber { get; set; }
        public string BeneficiaryName { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public long PhoneNumber { get; set; }
        public string City { get; set; }

        public List<VaccineInfo> VaccinationDetails
        {
            get; set;
        }


        public BeneficiaryInfo(string name, int age, Gender gender, long phNumber, string city)
        {
            this.BeneficiaryName = name;
            this.Age = age;
            this.Gender = Gender;
            this.PhoneNumber = phNumber;
            this.City = city;
            this.RegistrationNumber = autoIncrementRegNo++;

        }



    }
    /// <summary>
    ///   To choose gender(Male,Female,Transgender)
    /// </summary>
    public enum Gender
    {
        Male = 1,
        Female,
        Others
    }


}
