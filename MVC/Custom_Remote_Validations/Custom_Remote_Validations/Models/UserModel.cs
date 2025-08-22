using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Custom_Remote_Validations.Models
{
    public class UserModel : IValidatableObject
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public IEnumerable<ValidationResult>Validate(ValidationContext validationcontext)
        {
            if (this.BirthDay.Year < 1996)
                yield return new ValidationResult("Seems you are a bit Old for this Job", new[] { "BirthDay" });
            if (this.BirthDay.Year > 2003)
                yield return new ValidationResult("Seems you are young for this Job", new[] { "BirthDay" });
            if (this.BirthDay.Month == 4)
                yield return new ValidationResult("Sorry, we dont accept April Borns, for this Job", new[] { "BirthDay" });

            if ((this.BirthDay.DayOfWeek == DayOfWeek.Wednesday) && (this.Name != "Shivaji"))
                yield return new ValidationResult("Sorry to have been born on a wednesady, and we need your" +
                    "name to be Shivaji", new[] { "BirthDay", "Name" });
        }
    }
}