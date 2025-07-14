using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Project
{
    public class User
    {
        public Boolean IsAdmin { get; set; }
    }

    public class Reservation
    {
        public User bookedBy { get; set; }

        public bool CanbeCancelledBy(User user)
        {
            if(user.IsAdmin) 
                return true;
            if(bookedBy == user)
                return true;
            else return false;
        }
    }
}
