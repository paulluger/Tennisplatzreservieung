using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennisplatzreservierung
{
    class Reservation
    {
        private int reservationID;
        private int tennisCourtID;
        private int userID;
        private DateTime starttime;
        private TimeSpan duration;
        private int reservationType;

        public int ReservationID { get { return reservationID; } set { } }
        public int TennidCourtID { get { return tennisCourtID; } set { } }
        public int UserID { get { return userID; } set { }}
        public int ReservationType { get { return reservationID; } set { } }
        public DateTime Starttime
        {
            get
            {
                return starttime;
            }
            set
            {

            }
        }

        public TimeSpan Duration
        {
            get
            {
                return duration;
            }
            set
            {
                if(duration == TimeSpan.Zero)
                {
                    throw new ApplicationException("Die Dauer darf nicht 0h betragen!");
                }
                else
                {
                    duration = value;
                }
            }
        }
        
    }
}
