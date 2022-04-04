using CWM_VidlyGyak.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace CWM_VidlyGyak.ViewModels
{
    public class CustumerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        [Required]
        public DateTime? Birthdate { get; set; }

        [Display(Name = "Subscribe?")]
        [Required]
        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Membership Type")]
        [Required]
        public byte? MembershipTypeId { get; set; }


        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Customer" : "New Customer";
            }
        }

        public CustumerFormViewModel()
        {
            Id = 0;
        }

        public CustumerFormViewModel(Custumer custumer)
        {
            Id = custumer.Id;
            Name = custumer.Name;
            Birthdate = custumer.Birthdate;
            IsSubscribedToNewsletter = custumer.IsSubscribedToNewsletter;
            MembershipTypeId = custumer.MembershipTypeId;
            
        }
    }
}
