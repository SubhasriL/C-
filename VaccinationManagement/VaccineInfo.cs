using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccinationManagement
{
    class VaccineInfo
    {
        public VacType VaccineType { get; set; }
        public string Dosage { get; set; }
        public DateTime VaccinatedDate { get; set; }

      
        public VaccineInfo(VacType vaccineType, DateTime vaccinatedDate)
        {
            this.VaccineType = VaccineType;
            this.VaccinatedDate = vaccinatedDate;


        }




    }
    /// <summary>
    ///     To choose vaccine types(Covaxin,Covishield,Sputnic)
    /// </summary>>
    public enum VacType
    {
        Co_vaccine = 1,
        Covishield,
        Sputnic
    }
}
