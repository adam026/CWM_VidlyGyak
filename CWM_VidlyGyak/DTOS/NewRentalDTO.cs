using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CWM_VidlyGyak.DTOS
{
    public class NewRentalDTO
    {
        public int CustumerID { get; set; }
        public List<int> MovieIds { get; set; }
    }
}
