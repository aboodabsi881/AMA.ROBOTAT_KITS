 using AMA.ROBOTAT_KITS.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBOTAT_KITS.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string fName { get; set; }
        public int lName { get; set; }
        public Gender Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        [NotMapped]
        public string FullName
        { 
            get
            {
                return $"{fName + lName}";
            } 
        }
        [NotMapped]
        public int Age
        { 
            get
            {
                if (DateOfBirth.Value != null)
                {
                    return DateTime.Now.Year-DateOfBirth.Value.Year;
                }
                else
                { 
                    return 0;
                }
            } 
        }

    }
}    
