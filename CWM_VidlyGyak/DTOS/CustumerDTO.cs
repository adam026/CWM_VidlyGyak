using CWM_VidlyGyak.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CWM_VidlyGyak.DTOS
{
    public class CustumerDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

       // [Min18Years]
        public Nullable<System.DateTime> Birthdate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Required]
        public byte MembershipTypeId { get; set; }
        public MembershipTypeDTO MembershipType { get; set; }
    }
}
