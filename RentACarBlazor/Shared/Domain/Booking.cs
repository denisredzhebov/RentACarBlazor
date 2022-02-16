using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentACarBlazor.Shared.Domain
{
    public class Booking : BaseDomainModel, IValidatableObject
    {
        public int VehicleId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOut { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateIn { get; set; }
        public virtual Customer? Customer { get; set; }
        [Required]
        public int CustomerId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateIn != null)
            {
                if (DateIn <= DateOut)
                {
                    yield return new ValidationResult("Date In must be greater than Date Out", new[] { nameof(DateIn) });
                }
            }
            if (DateOut <= DateTime.Now)
            {
                yield return new ValidationResult("Date Out must be greater than today", new[] { nameof(DateOut) });
            }
        }
    }
}